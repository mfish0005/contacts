import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.interface';
import { ContactService } from 'src/app/services/contact.service';

@Component({
selector: 'home',
templateUrl: './home.component.html',
styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {
  contacts: Contact[] = [];

	constructor(private contactService: ContactService) {
	}

	ngOnInit() {
    this.contactService.getContacts().subscribe(contacts => {
      this.contacts = contacts;
      console.log(contacts);
    });
  }

  editContact(contact: Contact): void {
    console.log('editing a contact: ', contact);
  }

  deleteContact(contact: Contact): void {
    console.log('deleting a contact: ', contact);
    this.contactService.deleteContact(contact);
    // TODO: Trigger a lazy load once the contact is deleted
  }
}
