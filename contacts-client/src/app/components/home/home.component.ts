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

  contactsPageNumber: number = 1;

  contactCount;

	constructor(private contactService: ContactService, private router: Router) {
	}

	ngOnInit() {
    this.contactService.getContactCount().subscribe(res => {
      this.contactCount = res;
      this.virtualContacts = Array.from({length: this.contactCount}).map(() => this.contactService.generateContact());;
    })
  }

  // This wonderful method gets called twice by primeNG because hjklashdashjd;hlkjas
  lazyLoadContacts(event: LazyLoadEvent): void {

    this.contactsPageNumber = event.first <= 10 ? 1 : this.contactsPageNumber + 1;

    this.contactService.getPagedContacts(this.contactsPageNumber, event.rows).subscribe(contacts => {
      // Log the next page to demonstrate that it's using a paged response...
      console.log('%c GOT PAGE: ', 'color: green;', contacts);

      this.contacts = contacts;

      this.loadedContacts = this.contacts;

      // Problem starts here.  Pushes the first 10 rows TWICE grrrrrrrrr
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
      // TODO: This doesn't work.  Find another way of showing the user it's been deleted
      const contactIndex = this.virtualContacts.findIndex((el) => el.id === contact.id);
      this.virtualContacts.splice(contactIndex, 1);
    } else {
      return;
    }
  }

  goToAddContact(): void {
    this.router.navigate(['/add-contact']);
  }
}
