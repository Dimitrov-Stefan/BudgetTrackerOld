using BudgetTracker.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;

namespace BudgetTracker.Common
{
    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<FinancialItem> FinancialItems { get; set; }

        public DbSet<FinancialOperation> FinancialOperations { get; set; }
    }
}
