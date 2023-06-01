import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-nesting',
  templateUrl: './nesting.component.html',
  styleUrls: ['./nesting.component.css']
})
export class NestingComponent {
  @Input() name !: string;
  @Input() parentName !: string;
}
