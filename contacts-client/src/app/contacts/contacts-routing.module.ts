import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateContactComponent } from './components/create-contact/create-contact.component';
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
        path: 'create',
        component: CreateContactComponent,
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
