using BudgetTracker.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.DAL.Abstract
{
    public interface IFinancialItemRepository : IRepository<FinancialItem>
    {
        IEnumerable<FinancialItem> GetAll();
        void Add(FinancialItem entity);
    }
}
