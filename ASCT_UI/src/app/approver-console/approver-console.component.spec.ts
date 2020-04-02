import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ApproverConsoleComponent } from './approver-console.component';

describe('ApproverConsoleComponent', () => {
  let component: ApproverConsoleComponent;
  let fixture: ComponentFixture<ApproverConsoleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ApproverConsoleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ApproverConsoleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
