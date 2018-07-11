using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Dtos.FinancialOperationDtos
{
    public class FinancialOperationCreateDto
    {
        public DateTime Timestamp { get; set; }
        Guid FinancialItemId { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
    }
}
