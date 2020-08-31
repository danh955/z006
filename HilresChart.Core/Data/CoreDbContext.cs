// <copyright file="CoreDbContext.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Core database context class.
    /// </summary>
    public class CoreDbContext : IdentityDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions.</param>
        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }
    }
}