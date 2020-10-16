import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { OktaAuthService } from '@okta/okta-angular';
import { from, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
    providedIn: 'root'
})
export class AuthService {

    accessToken: string;

    constructor(private oktaAuthService: OktaAuthService, private http: HttpClient) {
        this.getAccessToken().subscribe(token => {
            this.accessToken = token;
            this.getHeadersWithBearer();
        });
    }

    getAccessToken(): Observable<string> {
        return from(this.oktaAuthService.getAccessToken());
    }

    getHeadersWithBearer(): HttpHeaders {
        const headers = new HttpHeaders()
            .set('Authorization', `Bearer ${this.accessToken}`);

        return headers;
    }

    login() {
        this.oktaAuthService.loginRedirect('/contacts');
    }

    async logout() {
        const idToken = await this.oktaAuthService.getIdToken();

        // Clear local session
        await this.oktaAuthService.logout('/');

        // Clear remote session
        window.location.href = `${environment.issuer}/v1/logout?id_token_hint=${idToken}&post_logout_redirect_uri=http://localhost:4200`;
    }

    getUserFromOkta() {
        const url = "https://dev-881723.okta.com/api/v1/users/me";

        const headers = new HttpHeaders()
        .set('Authorization', `Bearer ${this.accessToken}`);

        this.http.get(url, {headers}).subscribe(res => {
            console.log(res);
        })
    }
}
