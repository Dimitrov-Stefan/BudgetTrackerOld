using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Entities
{
    public class FinancialOperation : EntityBase
    {
        public DateTime Timestamp { get; set; }

        Guid FinancialItemId { get; set; }
        FinancialItem FinancialItem { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
