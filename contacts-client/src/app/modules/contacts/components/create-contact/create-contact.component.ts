import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { ContactService } from '../../services/contact.service';

@Component({
    selector: 'create-contact',
    templateUrl: './create-contact.component.html',
    styleUrls: ['./create-contact.component.scss']
})

export class CreateContactComponent implements OnInit {

    createContactForm = this.formBuilder.group({
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
        this.contactService.createContact(this.createContactForm.value).subscribe(res => {
            console.log(`%c ${res.name} was created successfully`, 'color: lightgreen', res);
            this.router.navigate(['/contacts']);
        });
    }

    cancel(): void {
        this.router.navigate(['/contacts']);
    }
}
