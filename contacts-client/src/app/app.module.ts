import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { VirtualScrollerModule } from 'primeng/virtualscroller';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { AddContactComponent } from './components/add-contact/add-contact.component';
import { EditContactComponent } from './components/edit-contact/edit-contact.component';

import { ContactService } from './services/contact.service';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
	declarations: [
		AppComponent,
    HomeComponent,
    AddContactComponent,
    EditContactComponent
	],
	imports: [
		BrowserModule,
		AppRoutingModule,
		BrowserAnimationsModule,
    VirtualScrollerModule,
    HttpClientModule,
    ReactiveFormsModule
	],
	providers: [
    ContactService
  ],
	bootstrap: [AppComponent]
})
export class AppModule { }
