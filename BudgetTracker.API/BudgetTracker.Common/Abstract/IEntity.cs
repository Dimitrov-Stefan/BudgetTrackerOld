using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Abstract
{
    public interface IEntity
    {
        Guid Id { get; set; }

        bool IsDeleted { get; set; }
    }
}
