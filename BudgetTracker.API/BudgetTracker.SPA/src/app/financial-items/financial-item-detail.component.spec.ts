import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialItemDetailComponent } from './financial-item-detail.component';

describe('FinancialItemDetailComponent', () => {
  let component: FinancialItemDetailComponent;
  let fixture: ComponentFixture<FinancialItemDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FinancialItemDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FinancialItemDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
