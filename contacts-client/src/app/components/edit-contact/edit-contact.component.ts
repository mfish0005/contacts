import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';

@Component({
selector: 'edit-contact',
templateUrl: './edit-contact.component.html',
styleUrls: ['./edit-contact.component.scss']
})

export class EditContactComponent implements OnInit {

  contactState: Contact;

  editContactForm = this.formBuilder.group({
    name: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    phone: [''],
    address: ['']
  });

	constructor(private contactService: ContactService, private formBuilder: FormBuilder, private router: Router, private route: ActivatedRoute) {
	}

	ngOnInit() {
    this.contactState = this.contactService.getContactState();
    this.editContactForm.controls.name.setValue(this.contactState.name);
    this.editContactForm.controls.email.setValue(this.contactState.email);
    this.editContactForm.controls.phone.setValue(this.contactState.phone);
    this.editContactForm.controls.address.setValue(this.contactState.address);
  }

  editContact(): void {
    let contact: Contact = new Contact();

    contact.name = this.editContactForm.value.name;
    contact.email = this.editContactForm.value.email;
    contact.phone = this.editContactForm.value.phone;
    contact.address = this.editContactForm.value.address;
    contact.id = parseInt(this.route.snapshot.params.id);

    this.contactService.editContact(contact).subscribe(res => {
      console.log(`%c ${res.name} was edited successfully`, 'color: lightgreen');
    });

    this.router.navigate(['']);
  }

  cancel(): void {
    this.router.navigate(['']);
  }
}
