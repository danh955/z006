// <copyright file="PortfolioService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Services
{
    using System.Collections.Generic;
    using HilresChart.Core.Data;
    using HilresChart.Core.Model;

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
        public List<Portfolio> GetUsersPortfolios(string userId)
        {
            return new List<Model.Portfolio>
            {
                new Portfolio { Id = 1, UserId = "101", Name = "Default" },
                new Portfolio { Id = 2, UserId = "102", Name = "Regular" },
            };
        }
    }
}