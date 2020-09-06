// <copyright file="ApplicationBuilderExtensions.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core
{
    using System;
    using HilresChart.Core.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Application builder extensions class.
    /// </summary>
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Ensure that the database is migrated.
        /// </summary>
        /// <param name="app">IApplicationBuilder.</param>
        /// <returns>With IApplicationBuilder.</returns>
        public static IApplicationBuilder EnsureDatabaseMigrated(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetService<CoreDbContext>();
            context.Database.Migrate();
            return app;
        }
    }
}