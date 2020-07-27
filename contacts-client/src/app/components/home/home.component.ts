import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';
import { Router } from '@angular/router';

@Component({
selector: 'home',
templateUrl: './home.component.html',
styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {

  contacts: Contact[] = [];

	constructor(private contactService: ContactService, private router: Router) {
	}

	ngOnInit() {
    this.contactService.getContacts().subscribe(contacts => {
      this.contacts = contacts;
    });
  }

  editContact(contact: Contact): void {
    console.log('editing a contact: ', contact);
    this.contactService.setContactState(contact);
    this.router.navigateByUrl(
      `/edit-contact/${contact.id}`,
    );
  }

  deleteContact(contact: Contact): void {
    console.log('deleting a contact: ', contact);
    this.contactService.deleteContact(contact);
    // TODO: Trigger a lazy load once the contact is deleted
  }

  goToAddContact(): void {
    this.router.navigate(['/add-contact']);
  }
}
