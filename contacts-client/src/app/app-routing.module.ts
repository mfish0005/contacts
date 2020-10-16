import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { OktaCallbackComponent, OktaAuthGuard } from '@okta/okta-angular';

const routes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'implicit/callback',
        component: OktaCallbackComponent
    },
    {
        path: 'contacts',
        loadChildren: () => import('./contacts/contacts.module').then(m => m.ContactsModule),
        canActivate: [OktaAuthGuard]
    },
    {
        path: '**',
        redirectTo: ''
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
