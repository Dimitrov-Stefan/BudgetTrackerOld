import { TestBed, inject } from '@angular/core/testing';

import { FinancialItemService } from './financial-item.service';

describe('FinancialItemService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [FinancialItemService]
    });
  });

  it('should be created', inject([FinancialItemService], (service: FinancialItemService) => {
    expect(service).toBeTruthy();
  }));
});
