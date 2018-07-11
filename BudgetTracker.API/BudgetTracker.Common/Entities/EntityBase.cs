using BudgetTracker.Common.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Entities
{
    public class EntityBase : IEntity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
