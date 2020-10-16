import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { VirtualScrollerModule } from 'primeng/virtualscroller';

import { ContactsRoutingModule } from './contacts-routing.module';
import { EditContactGuard } from './components/edit-contact/edit-contact.guard';
import { ContactService } from './services/contact.service';
import { ViewContactsComponent } from './components/view-contacts/view-contacts.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';

@NgModule({
    declarations: [
        ViewContactsComponent,
        AddContactComponent,
        EditContactComponent
    ],
    imports: [
        CommonModule,
        VirtualScrollerModule,
        ReactiveFormsModule,
        ContactsRoutingModule
    ],
    providers: [
        ContactService,
        EditContactGuard
    ]
})
export class ContactsModule { }
