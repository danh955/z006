// <copyright file="PortfolioService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using HilresChart.Core.Data;
    using HilresChart.Core.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Portfolio service class.
    /// </summary>
    public class PortfolioService : IPortfolioService
    {
        private readonly CoreDbContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioService"/> class.
        /// </summary>
        /// <param name="dbContext">DbContext.</param>
        public PortfolioService(CoreDbContext dbContext)
        {
            this.db = dbContext;
        }

        /// <inheritdoc/>
        public async Task<List<Portfolio>> GetUsersPortfoliosAsync(string userId)
        {
            return await this.db.Portfolios.ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Portfolio> AddAsync(Portfolio portfolio)
        {
            this.db.Portfolios.Add(portfolio);
            await this.db.SaveChangesAsync().ConfigureAwait(false);
            return portfolio;
        }
    }
}