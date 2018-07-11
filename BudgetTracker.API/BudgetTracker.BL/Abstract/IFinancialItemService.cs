using BudgetTracker.Common.Dtos.FinancialItemDtos;
using BudgetTracker.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.BL.Abstract
{
    public interface IFinancialItemService
    {
        FinancialItemGetDto GetById(Guid id);

        IList<FinancialItemGetDto> GetAll();

        void Create(FinancialItemCreateDto financialItemCreateDto);
    }
}
