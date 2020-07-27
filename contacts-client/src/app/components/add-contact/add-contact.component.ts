import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact.model';
import { ContactService } from 'src/app/services/contact.service';
import { FormControl } from '@angular/forms';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
selector: 'add-contact',
templateUrl: './add-contact.component.html',
styleUrls: ['./add-contact.component.scss']
})

export class AddContactComponent implements OnInit {
  name = new FormControl('');
  addContactForm = this.formBuilder.group({
    name: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]]
  });
	constructor(private contactService: ContactService, private formBuilder: FormBuilder, private router: Router) {
	}

	ngOnInit() {
  }

  createContact(): void {
    this.contactService.createContact(this.addContactForm.value).subscribe(res => {
      console.log(res)
    });
  }

  cancel(): void {
    this.router.navigate(['']);
  }
}
