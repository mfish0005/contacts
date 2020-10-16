import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';

@Injectable({
    providedIn: 'root'
})
export class AuthGuard implements CanActivate {
    canActivate(): boolean {
        // If a user is authenticated return true
        return true;
        // Else redirect them to the login screen
    }
}
