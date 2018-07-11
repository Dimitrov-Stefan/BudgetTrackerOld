using BudgetTracker.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.DAL.Abstract
{
    public interface IFinancialOperationRepository : IRepository<FinancialOperation>
    {
        IEnumerable<FinancialOperation> GetAll();
        void Add(FinancialOperation entity);
    }
}
