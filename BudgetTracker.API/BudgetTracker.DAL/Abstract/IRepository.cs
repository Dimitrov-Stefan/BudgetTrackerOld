using BudgetTracker.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.DAL.Abstract
{
    public interface IRepository<T> where T : IEntity
    {
        T GetEntityById(Guid id);

        IEnumerable<T> GetAllEntities();

        IEnumerable<T> GetAllEntities(int pageNumber, int itemsPerPage);

        void AddEntity(T entity);

        void SaveChanges();
    }
}
