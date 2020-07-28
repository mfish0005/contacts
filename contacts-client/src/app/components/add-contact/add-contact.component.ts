import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { ContactService } from 'src/app/services/contact.service';

@Component({
selector: 'add-contact',
templateUrl: './add-contact.component.html',
styleUrls: ['./add-contact.component.scss']
})

export class AddContactComponent implements OnInit {

  addContactForm = this.formBuilder.group({
    name: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    phone: [''],
    address: ['']
  });

	constructor(private contactService: ContactService, private formBuilder: FormBuilder, private router: Router) {
	}

	ngOnInit() {
  }

  createContact(): void {
    this.contactService.createContact(this.addContactForm.value).subscribe(res => {
      console.log(`%c ${res.name} was created successfully`, 'color: lightgreen');
    });
    this.router.navigate(['']);
  }

  cancel(): void {
    this.router.navigate(['']);
  }
}
