using BudgetTracker.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.Dtos.FinancialItemDtos
{
    public class FinancialItemGetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public FinancialItemType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
