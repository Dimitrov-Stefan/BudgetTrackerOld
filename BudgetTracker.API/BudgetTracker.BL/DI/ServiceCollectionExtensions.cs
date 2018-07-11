using BudgetTracker.BL.Abstract;
using BudgetTracker.BL.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.BL.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlDependencies(this IServiceCollection services)
        {
            services.AddTransient<IFinancialItemService, FinancialItemService>();
            services.AddTransient<IFinancialOperationService, FinancialOperationService>();
            return services;
        }
    }
}
