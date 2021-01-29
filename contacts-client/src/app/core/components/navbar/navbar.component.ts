import { Component, OnInit } from '@angular/core';
import { OktaAuthService } from '@okta/okta-angular';

import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html',
    styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

    burgerActive: boolean;
    isAuthenticated: boolean;

    constructor(private oktaAuthService: OktaAuthService, private authService: AuthService, private router: Router) {
        this.oktaAuthService.$authenticationState.subscribe(
            (isAuthenticated: boolean) => this.isAuthenticated = isAuthenticated
        );
    }

    async ngOnInit(): Promise<void> {
        this.isAuthenticated = await this.oktaAuthService.isAuthenticated();
    }

    toggleBurger(): void {
        this.burgerActive = !this.burgerActive;
    }

    logout(): void {
        this.authService.logout();
    }

    login(): void {
        this.authService.login();
    }

    goToHome(): void {
        this.router.navigate(['/home']);
    }

    goToContacts(): void {
        this.router.navigate(['/contacts']);
    }
}
