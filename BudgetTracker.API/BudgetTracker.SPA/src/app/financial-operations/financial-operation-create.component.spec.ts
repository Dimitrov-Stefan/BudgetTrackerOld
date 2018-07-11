import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialOperationCreateComponent } from './financial-operation-create.component';

describe('FinancialOperationCreateComponent', () => {
  let component: FinancialOperationCreateComponent;
  let fixture: ComponentFixture<FinancialOperationCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FinancialOperationCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancialOperationCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
