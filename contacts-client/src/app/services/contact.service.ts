import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Contact } from '../models/contact.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactService {

  contactState: Contact = new Contact();

  baseUrl: string = 'http://localhost:61953/contacts';

  constructor(private http: HttpClient) { }

  getContactState(): Contact {
    return this.contactState;
  }

  setContactState(contact: Contact): void {
    this.contactState.id = contact.id;
    this.contactState.name = contact.name;
    this.contactState.email = contact.email;
  }

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.baseUrl);
  }

  getContactById(id: number): Observable<Contact> {
    return this.http.get<Contact>(`${this.baseUrl}/${id}`);
  }

  createContact(contact: Contact): Observable<Contact> {
    return this.http.post<Contact>(this.baseUrl, contact);
  }

  deleteContact(contact: Contact): Observable<Contact> {
    const url = `${this.baseUrl}/${contact.id}`;

    return this.http.delete<Contact>(url);
  }

  editContact(contact: Contact): Observable<Contact> {
    const url = `${this.baseUrl}/${contact.id}`;

    return this.http.put<Contact>(url, contact);
  }
}
