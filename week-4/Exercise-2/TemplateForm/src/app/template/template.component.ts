import { Component } from '@angular/core';




@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
export class TemplateComponent {
  name: string='';
  email: string='';
  password: string='';
  


  submitForm() {
    // Handle form submission logic here
  }

}
