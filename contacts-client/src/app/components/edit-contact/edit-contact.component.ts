import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';
import { FormControl } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
selector: 'edit-contact',
templateUrl: './edit-contact.component.html',
styleUrls: ['./edit-contact.component.scss']
})

export class EditContactComponent implements OnInit {

  contactState: Contact;

  editContactForm = this.formBuilder.group({
    name: [''],
    email: ['']
  });

	constructor(private contactService: ContactService, private formBuilder: FormBuilder, private router: Router, private route: ActivatedRoute) {
	}

	ngOnInit() {
    this.contactState = this.contactService.getContactState();
    this.editContactForm.controls.name.setValue(this.contactState.name);
    this.editContactForm.controls.email.setValue(this.contactState.email);
  }

  editContact(): void {
    // Instantiate a contact so we can add the id to the payload
    let contact: Contact = new Contact();
    contact.name = this.editContactForm.value.name;
    contact.email = this.editContactForm.value.email;
    contact.id = parseInt(this.route.snapshot.params.id);

    this.contactService.editContact(contact).subscribe(res => {
      console.log(res)
    });

    this.router.navigate(['']);
  }

  cancel(): void {
    this.router.navigate(['']);
  }
}
