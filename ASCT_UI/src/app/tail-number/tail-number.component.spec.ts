import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TailNumberComponent } from './tail-number.component';

describe('TailNumberComponent', () => {
  let component: TailNumberComponent;
  let fixture: ComponentFixture<TailNumberComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TailNumberComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TailNumberComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
