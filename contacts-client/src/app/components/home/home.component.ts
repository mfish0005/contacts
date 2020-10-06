import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';
import { Router } from '@angular/router';
import { LazyLoadEvent } from 'primeng/api';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {
    contacts: Contact[] = [];

    virtualContacts: Contact[] = [];

    loadedContacts: Contact[] = [];

    pageDifference: number = 0;

    contactCount;

    constructor(private contactService: ContactService, private router: Router) {
    }

    ngOnInit() {
        this.contactService.getContactCount().subscribe(res => {
            this.contactCount = res;
            this.virtualContacts = Array.from({ length: this.contactCount });;
        })
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
        this.router.navigateByUrl(
            `/edit-contact/${contact.id}`,
        );
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
        this.router.navigate(['/add-contact']);
    }
}
