import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.interface';
import { ContactService } from 'src/app/services/contact.service';

@Component({
selector: 'edit-contact',
templateUrl: './edit-contact.component.html',
styleUrls: ['./edit-contact.component.scss']
})

export class EditContactComponent implements OnInit {

	constructor(private contactService: ContactService) {
	}

	ngOnInit() {
  }
}
