// <copyright file="ServiceCollectionExtensions.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    using HilresChart.Core.Data;
    using HilresChart.Core.Services;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Service collection extensions class.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Add core serves.
        /// </summary>
        /// <param name="services">IServiceCollection.</param>
        /// <param name="connectionString">Connection string.</param>
        /// <returns>Updated IServiceCollection.</returns>
        public static IServiceCollection AddCoreServes(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CoreDbContext>(options => options.UseSqlite(connectionString));
            services.AddTransient<IPortfolioService, PortfolioService>();

            return services;
        }
    }
}