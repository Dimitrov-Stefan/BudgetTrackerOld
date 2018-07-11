import { TestBed, inject } from '@angular/core/testing';

import { FinancialOperationService } from './financial-operation.service';

describe('FinancialOperationService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FinancialOperationService]
    });
  });

  it('should be created', inject([FinancialOperationService], (service: FinancialOperationService) => {
    expect(service).toBeTruthy();
  }));
});
