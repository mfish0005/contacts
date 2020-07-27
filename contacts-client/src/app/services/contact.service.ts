import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Contact } from '../models/contact.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  baseUrl: string = 'http://localhost:61953/contacts';

  constructor(private http: HttpClient) { }

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.baseUrl);
  }

  createContact(contact: Contact): Observable<Contact> {
    return this.http.post<Contact>(this.baseUrl, contact);
  }

  deleteContact(contact: Contact): Observable<Contact> {
    const url = `${this.baseUrl}/${contact.id}`;

    return this.http.delete<Contact>(url);
  }
}
