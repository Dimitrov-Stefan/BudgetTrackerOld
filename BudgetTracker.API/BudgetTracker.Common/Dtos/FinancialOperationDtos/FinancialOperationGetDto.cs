using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Dtos.FinancialOperationDtos
{
    public class FinancialOperationGetDto
    {
        public DateTime Timestamp { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
