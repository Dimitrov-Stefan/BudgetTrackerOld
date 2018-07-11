import { TestBed, inject } from '@angular/core/testing';

import { FinancialItemGuardService } from './financial-item-guard.service';

describe('FinancialItemGuardService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FinancialItemGuardService]
    });
  });

  it('should be created', inject([FinancialItemGuardService], (service: FinancialItemGuardService) => {
    expect(service).toBeTruthy();
  }));
});
