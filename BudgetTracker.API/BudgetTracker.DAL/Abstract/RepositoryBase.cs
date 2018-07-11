using BudgetTracker.Common;
using BudgetTracker.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetTracker.DAL.Abstract
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : EntityBase
    {
        private readonly BudgetTrackerDbContext context;

        protected DbSet<T> dbSet;

        public RepositoryBase(BudgetTrackerDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public T GetEntityById(Guid id)
        {
            return dbSet.Find(id);
        }

        public void AddEntity(T entity)
        {
            entity.Id = Guid.NewGuid();
            entity.IsDeleted = false;
            dbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public IEnumerable<T> GetAllEntities()
        {
            return dbSet.ToList();
        }

        public IEnumerable<T> GetAllEntities(int pageNumber, int itemsPerPage)
        {
            return dbSet.Skip(pageNumber * itemsPerPage).Take(itemsPerPage).ToList();
        }
    }
}
