using BudgetTracker.DAL.Abstract;
using BudgetTracker.DAL.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.DAL.DI
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDalDependencies(this IServiceCollection services)
        {
            services.AddScoped<IFinancialItemRepository, FinancialItemRepository>();
            services.AddScoped<IFinancialOperationRepository, FinancialOperationRepository>();

            return services;
        }
    }
}
