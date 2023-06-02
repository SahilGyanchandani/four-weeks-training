// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-login',
//   templateUrl: './login.component.html',
//   styleUrls: ['./login.component.css']
// })
// export class LoginComponent {

// }

import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  username: string="";
  password: string="";

  constructor(private router: Router) { }

  // login() {
  //   // Perform dummy authentication
  //   const isAuthenticated = this.username === 'admin' && this.password === 'sahil';
   

  //   if (isAuthenticated) {
  //     // Redirect to a protected route
  //     this.router.navigate(['/dashboard']);
  //   } else {
  //     // Show an error message or handle the failed login attempt
  //     console.log('Invalid username or password');
  //   }
  // }

  login() {
    let isAuthenticated: boolean;
  
    if (this.username === "admin" && this.password === "sahil") {
      isAuthenticated = true;
      // Redirect to a protected route
      this.router.navigate(['/dashboard']);
    } else {
      isAuthenticated = false;
      // Show an error message or handle the failed login attempt
      console.log('Invalid username or password');
    }
  
    // You can now access the value of isAuthenticated outside of the if-else blocks
    console.log(this.username);
  }
}
