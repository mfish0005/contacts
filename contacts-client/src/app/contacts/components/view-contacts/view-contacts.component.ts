import { Component, OnInit } from '@angular/core';
import { Contact } from '../../models/contact.model';
import { ContactService } from '../../services/contact.service';
import { OktaAuthService } from '@okta/okta-angular';
import { Router } from '@angular/router';
import { LazyLoadEvent } from 'primeng/api';

@Component({
  selector: 'app-view-contacts',
  templateUrl: './view-contacts.component.html',
  styleUrls: ['./view-contacts.component.scss']
})
export class ViewContactsComponent implements OnInit {

    contacts: Contact[] = [];

    virtualContacts: Contact[] = [];

    loadedContacts: Contact[] = [];

    pageDifference: number = 0;

    contactCount: number;

    isAuthenticated: boolean;

    constructor(private contactService: ContactService, private oktaAuthService: OktaAuthService, private router: Router) {
        this.oktaAuthService.$authenticationState.subscribe(
            (isAuthenticated: boolean) => this.isAuthenticated = isAuthenticated
        );
    }

    ngOnInit() {
        this.contactService.getContactCount().subscribe(res => {
            this.contactCount = res;
            console.log(this.contactCount)
            this.virtualContacts = Array.from({ length: this.contactCount });;
        });
    }

    lazyLoadContacts(event: LazyLoadEvent): void {
        if (event.first !== 0) {
            this.pageDifference = this.pageDifference + 24;
        }

        this.contactService.getPagedContacts(event.first - this.pageDifference, event.rows).subscribe(contacts => {
            // Log the contacts to demonstrate that it's using a paged response
            console.log('%c GOT PAGE: ', 'color: green;', contacts);

            this.contacts = contacts;

            this.loadedContacts = this.contacts;

            Array.prototype.splice.apply(this.virtualContacts, [...
                [event.first, event.rows], ...this.loadedContacts]);

            this.virtualContacts = [...this.virtualContacts];
        });
    }

    editContact(contact: Contact): void {
        this.contactService.setContactState(contact);
        this.router.navigate([`/contacts/edit/${contact.id}`]);
    }

    deleteContact(contact: Contact): void {
        const confirmed = confirm(`Are you sure you wish to delete ${contact.name} ?`);

        if (confirmed) {
            this.contactService.deleteContact(contact).subscribe();
            window.location.reload();
        } else {
            return;
        }
    }

    goToAddContact(): void {
        this.router.navigate(['/contacts/add']);
    }

}
