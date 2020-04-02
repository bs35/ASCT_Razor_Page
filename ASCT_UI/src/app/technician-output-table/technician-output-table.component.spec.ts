import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TechnicianOutputTableComponent } from './technician-output-table.component';

describe('TechnicianOutputTableComponent', () => {
  let component: TechnicianOutputTableComponent;
  let fixture: ComponentFixture<TechnicianOutputTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TechnicianOutputTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TechnicianOutputTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
