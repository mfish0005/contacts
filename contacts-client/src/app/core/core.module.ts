import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule} from '@angular/common/http';

import { OktaAuthModule, OKTA_CONFIG } from '@okta/okta-angular';

import { environment } from '../../environments/environment';
import { AuthService } from './services/auth.service';
import { NavbarComponent } from './components/navbar/navbar.component';

const oktaConfig = {
    issuer: environment.issuer,
    clientId: environment.clientId,
    redirectUri: environment.redirectUri,
    scope: environment.scopes
};

/**
 * The CoreModule is responsible for TWO things:
 * 1. Shared singleton services aka services that will have a single instance shared between multiple modules.
 * 2. App-level components. E.G. The navbar will only be imported in app because it lives on every page
 */
@NgModule({
    declarations: [
        NavbarComponent
    ],
    imports: [
        CommonModule,
        OktaAuthModule,
        HttpClientModule
    ],
    providers: [
        AuthService,
        { provide: OKTA_CONFIG, useValue: oktaConfig }
    ],
    exports: [
        NavbarComponent
    ]
})
export class CoreModule { }
