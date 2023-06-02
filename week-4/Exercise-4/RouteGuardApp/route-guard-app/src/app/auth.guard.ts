

import { Injectable } from '@angular/core';
import {CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(private router: Router) { }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {

    // Check user login status
    const isLoggedIn = this.checkUserLoginStatus();

    // Put your authentication logic here
    const isAuthenticated = true; // Replace with your authentication check

    if (isLoggedIn && isAuthenticated) {
      return true; // Allow navigation to the route
    } else {
      // Redirect to a login page or any other route
      this.router.navigate(['/login']);
      return false; // Block navigation to the route
    }
  }

  private checkUserLoginStatus(): boolean {
    // Implement your logic to check if the user is logged in
    // Return true if the user is logged in, false otherwise

    // Placeholder implementation - always return true
    return true;
  }
}

