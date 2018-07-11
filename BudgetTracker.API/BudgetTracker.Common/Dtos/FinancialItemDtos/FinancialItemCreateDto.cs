using BudgetTracker.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetTracker.Common.Dtos.FinancialItemDtos
{
    public class FinancialItemCreateDto
    {
        public string Name { get; set; }
        public FinancialItemType Type { get; set; }
        public bool IsActive { get; set; }
    }
}
