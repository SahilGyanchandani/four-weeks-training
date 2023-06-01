import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NestingComponent } from './nesting.component';

describe('NestingComponent', () => {
  let component: NestingComponent;
  let fixture: ComponentFixture<NestingComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [NestingComponent]
    });
    fixture = TestBed.createComponent(NestingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
