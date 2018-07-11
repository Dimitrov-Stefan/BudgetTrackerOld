using System.Collections.Generic;
using BudgetTracker.Common;
using BudgetTracker.Common.Entities;
using BudgetTracker.DAL.Abstract;

namespace BudgetTracker.DAL.Concrete
{
    public class FinancialItemRepository : RepositoryBase<FinancialItem>, IFinancialItemRepository
    {
        public FinancialItemRepository(BudgetTrackerDbContext context) : base(context)
        {

        }

        public void Add(FinancialItem entity)
        {
            entity.IsActive = true;
            base.AddEntity(entity);
            base.SaveChanges();
        }

        public IEnumerable<FinancialItem> GetAll()
        {
            return base.GetAllEntities();
        }
    }
}
