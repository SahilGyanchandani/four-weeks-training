import { Component } from '@angular/core';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})
export class HelloComponent {
  childName: string = "child";
  parentName: string = "hello";
  name = 'Sahil Gyanchandani';
  color = 'White';
  changeColor() {
    // this.color = 'red';
    const colors = ['white', 'blue', 'red', 'green', 'yellow'];
    const currentIndex = colors.indexOf(this.color);
    const nextIndex = (currentIndex + 1) % colors.length;
    this.color = colors[nextIndex];
  }
}

