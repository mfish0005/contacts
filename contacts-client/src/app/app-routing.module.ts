import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { EditContactGuard } from './components/edit-contact/edit-contact.guard';
import { HomeComponent } from './components/home/home.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';

const routes: Routes = [
    {
        path: '',
        component: HomeComponent
    },
    {
        path: 'add-contact',
        component: AddContactComponent,
    },
    {
        path: 'edit-contact/:id',
        component: EditContactComponent,
        canActivate: [EditContactGuard]
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
