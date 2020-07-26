import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.interface';
import { ContactService } from 'src/app/services/contact.service';

@Component({
selector: 'add-contact',
templateUrl: './add-contact.component.html',
styleUrls: ['./add-contact.component.scss']
})

export class AddContactComponent implements OnInit {

	constructor(private contactService: ContactService) {
	}

	ngOnInit() {
  }
}
