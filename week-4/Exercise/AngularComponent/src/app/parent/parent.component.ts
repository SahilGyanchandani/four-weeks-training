import { Component } from '@angular/core';
@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  items: string[] = ['Books', 'Self', 'Table'];

  removeItem(index: number): void {
    this.items.splice(index, 1);
  }
}










