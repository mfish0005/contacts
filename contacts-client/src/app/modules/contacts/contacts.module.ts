import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { VirtualScrollerModule } from 'primeng/virtualscroller';
import { HeroModule } from 'fish-common';
import { SharedModule } from '../../shared/shared.module';
import { ContactsRoutingModule } from './contacts-routing.module';

import { EditContactGuard } from './components/edit-contact/edit-contact.guard';
import { ContactService } from './services/contact.service';
import { ViewContactsComponent } from './components/view-contacts/view-contacts.component';
import { CreateContactComponent } from './components/create-contact/create-contact.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';

@NgModule({
    declarations: [
        ViewContactsComponent,
        CreateContactComponent,
        EditContactComponent
    ],
    imports: [
        CommonModule,
        SharedModule,
        VirtualScrollerModule,
        ReactiveFormsModule,
        ContactsRoutingModule,
        HeroModule
    ],
    providers: [
        ContactService,
        EditContactGuard
    ]
})
export class ContactsModule { }
