import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FleetSelectComponent } from './fleet-select.component';

describe('FleetSelectComponent', () => {
  let component: FleetSelectComponent;
  let fixture: ComponentFixture<FleetSelectComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FleetSelectComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FleetSelectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
