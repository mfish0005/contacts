import { CanActivate, Router } from '@angular/router';
import { Injectable } from '@angular/core';
import { Contact } from '../../models/contact.model';
import { ContactService } from '../../services/contact.service';

@Injectable()
export class EditContactGuard implements CanActivate {

    contactState: Contact;

    constructor(public router: Router, private contactService: ContactService) { }

    canActivate(): boolean {
        this.contactState = this.contactService.getContactState();

        if (this.contactState && this.contactState.name && this.contactState.email) {
            return true;
        } else {
            // If we don't have a contact send the user back to contacts
            this.router.navigate(['/contacts']);
            return false;
        }
    }
}
