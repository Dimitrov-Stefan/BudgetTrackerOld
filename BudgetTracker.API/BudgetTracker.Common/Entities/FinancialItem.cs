using BudgetTracker.Common.Abstract;
using BudgetTracker.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Entities
{
    public class FinancialItem : EntityBase
    {
        public string Name { get; set; }
        public FinancialItemType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
