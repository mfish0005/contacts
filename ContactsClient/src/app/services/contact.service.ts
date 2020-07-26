import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Contact } from '../models/contact.interface';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  constructor(private http: HttpClient) { }

  getContacts(): Observable<Contact[]> {
    const url = 'http://localhost:61953/contacts';

    console.log('fired')
    return this.http.get<Contact[]>(url);
  }

  deleteContact(contact: Contact): void {
    const url = `http://localhost:61953/contacts/${contact.id}`;

    this.http.delete<Contact>(url).subscribe(res => {
      console.log(res);
    });
  }
}
