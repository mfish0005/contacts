import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddContactComponent } from './components/add-contact/add-contact.component';
import { OktaAuthGuard } from '@okta/okta-angular';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';
import { EditContactGuard } from './components/edit-contact/edit-contact.guard';
import { ViewContactsComponent } from './components/view-contacts/view-contacts.component';

const routes: Routes = [
    {
        path: '',
        component: ViewContactsComponent,
        canActivate: [OktaAuthGuard]
    },
    {
        path: 'add',
        component: AddContactComponent,
        canActivate: [OktaAuthGuard]
    },
    {
        path: 'edit/:id',
        component: EditContactComponent,
        canActivate: [OktaAuthGuard, EditContactGuard]
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
      exports: [RouterModule]
})
export class ContactsRoutingModule { }
