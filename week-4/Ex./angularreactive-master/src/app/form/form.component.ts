import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup,FormArray, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  form: FormGroup;
  hobbyForm: FormGroup;

  constructor(private formBuilder: FormBuilder) {}
    ngOnInit() {
      this.form = this.formBuilder.group({
        firstName: ['', [Validators.required, Validators.pattern(/^[a-zA-Z]+$/)]],
        lastName: ['', [Validators.required, Validators.pattern(/^[a-zA-Z]+$/)]],
        email: ['', [Validators.required, Validators.email]],
        password: ['', [Validators.required, Validators.minLength(8),Validators.maxLength(15), Validators.pattern(/^(?=.*[a-zA-Z])(?=.*[0-9])[a-zA-Z0-9]+$/)]]
        
      
      });

      this.hobbyForm = this.formBuilder.group({
        hobbies: this.formBuilder.array([this.createHobbyField()])
      });
    }

    createHobbyField(): FormGroup {
      return this.formBuilder.group({
        hobby: ['', Validators.required]
      });
    }
  onSubmit() {
    if (this.form.valid) {
      console.log(this.form.value); // Display form data in the console
    }
  }
  get hobbies(): FormArray {
    return this.hobbyForm.get('hobbies') as FormArray;
  }

  addHobbyField(): void {
    this.hobbies.push(this.createHobbyField());
  }

  removeHobbyField(index: number): void {
    this.hobbies.removeAt(index);
  }

}
