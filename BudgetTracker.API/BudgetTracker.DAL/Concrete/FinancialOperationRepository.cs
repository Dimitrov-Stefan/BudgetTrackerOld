using BudgetTracker.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using BudgetTracker.Common.Entities;
using BudgetTracker.Common;
using System.Linq;

namespace BudgetTracker.DAL.Concrete
{
    public class FinancialOperationRepository : RepositoryBase<FinancialOperation>, IFinancialOperationRepository
    {
        public FinancialOperationRepository(BudgetTrackerDbContext context) : base(context)
        {

        }

        public void Add(FinancialOperation entity)
        {
            base.AddEntity(entity);
            base.SaveChanges();
        }

        public IEnumerable<FinancialOperation> GetAll()
        {
            return base.GetAllEntities();
        }
    }
}
