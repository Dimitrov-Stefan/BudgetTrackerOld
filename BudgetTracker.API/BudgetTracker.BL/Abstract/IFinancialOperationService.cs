using BudgetTracker.Common.Dtos.FinancialOperationDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.BL.Abstract
{
    public interface IFinancialOperationService
    {
        FinancialOperationGetDto GetById(Guid id);

        IList<FinancialOperationGetDto> GetAll();

        void Create(FinancialOperationCreateDto financialItemCreateDto);
    }
}
