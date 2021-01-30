import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Contact } from '../models/contact.model';

@Injectable({
    providedIn: 'root'
})
export class ContactService {

    contactState: Contact = new Contact();
    baseUrl: string = 'http://localhost:5000/api/contacts';

    constructor(private http: HttpClient) { }

    getContactState(): Contact {
        return this.contactState;
    }

    setContactState(contact: Contact): void {
        this.contactState.id = contact.id;
        this.contactState.name = contact.name;
        this.contactState.email = contact.email;
        this.contactState.phone = contact.phone;
        this.contactState.address = contact.address;
    }

    getContactCount(): Observable<number> {
        const url = `${this.baseUrl}/count`;

        return this.http.get<number>(url);
    }

    getContactsPage(pageNumber: number, pageSize: number) {
        const httpParams: HttpParams = new HttpParams()
            .set('pageNumber', pageNumber.toString())
            .set('pageSize', pageSize.toString());

        const httpOptions: object = {
            params: httpParams,
            responseType: 'json'
        }

        return this.http.get<Contact[]>(this.baseUrl, httpOptions);
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
