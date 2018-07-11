import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialItemCreateComponent } from './financial-item-create.component';

describe('FinancialItemCreateComponent', () => {
  let component: FinancialItemCreateComponent;
  let fixture: ComponentFixture<FinancialItemCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FinancialItemCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancialItemCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
