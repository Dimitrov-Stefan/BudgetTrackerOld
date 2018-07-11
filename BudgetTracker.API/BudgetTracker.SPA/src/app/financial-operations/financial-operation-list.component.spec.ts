import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialOperationListComponent } from './financial-operation-list.component';

describe('FinancialOperationListComponent', () => {
  let component: FinancialOperationListComponent;
  let fixture: ComponentFixture<FinancialOperationListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FinancialOperationListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancialOperationListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
