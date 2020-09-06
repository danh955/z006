// <copyright file="Portfolio.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Model
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Portfolio class.
    /// </summary>
    public class Portfolio
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets user ID.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets name of portfolio.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// On model creating configures the entity.
        /// </summary>
        /// <param name="builder">ModelBuilder.</param>
        internal static void OnModelCreating(ModelBuilder builder)
        {
            var portfolio = builder.Entity<Portfolio>();
            portfolio.HasKey(p => p.Id);
            portfolio.HasIndex(p => new { p.UserId, p.Name }).IsUnique();
        }
    }
}