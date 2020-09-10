// <copyright file="IPortfolioService.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using HilresChart.Core.Model;

    /// <summary>
    /// Portfolio service interface.
    /// </summary>
    public interface IPortfolioService
    {
        /// <summary>
        /// Get the users portfolios.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <returns>List of portfolios.</returns>
        Task<List<Portfolio>> GetUsersPortfoliosAsync(string userId);

        /// <summary>
        /// Get the portfolio by its ID.
        /// </summary>
        /// <param name="id">The portfolio ID.</param>
        /// <returns>Portfolio.  Null if not found.</returns>
        Task<Portfolio> GetPortfolioById(int id);

        /// <summary>
        /// Add a portfolio.
        /// </summary>
        /// <param name="portfolio">Portfolio to added.</param>
        /// <returns>Portfolio.</returns>
        Task<Portfolio> AddAsync(Portfolio portfolio);
    }
}