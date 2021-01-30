import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NullHelperService } from './services/null-helper.service';

// The purpose of this module is to offer users the option to import all utility services through a single module
@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers: [NullHelperService]
})
export class UtilitiesModule { }
