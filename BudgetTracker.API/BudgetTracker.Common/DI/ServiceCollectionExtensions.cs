using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTracker.Common.DI
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCommonDependencies(this IServiceCollection services)
        {
            services.AddDbContext<BudgetTrackerDbContext>();
            return services;
        }
    }
}
