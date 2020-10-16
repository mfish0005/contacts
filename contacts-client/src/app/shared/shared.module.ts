import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthGuard } from './guards';

/**
 * Any component, model, directive, guard, or pipe that is used
 * in two or more other modules belongs in the shared module
 */
@NgModule({
    declarations: [],
    imports: [
        CommonModule,
    ],
    providers: [
        AuthGuard,
    ]
})
export class SharedModule { }
