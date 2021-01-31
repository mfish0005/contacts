import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeroModule } from 'fish-common';

import { HomeComponent } from './components/home.component';
import { HomeRoutingModule } from './home-routing.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    HeroModule
  ]
})
export class HomeModule { }
