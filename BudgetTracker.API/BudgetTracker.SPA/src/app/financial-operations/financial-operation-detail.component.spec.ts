import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialOperationDetailComponent } from './financial-operation-detail.component';

describe('FinancialOperationDetailComponent', () => {
  let component: FinancialOperationDetailComponent;
  let fixture: ComponentFixture<FinancialOperationDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FinancialOperationDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancialOperationDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
