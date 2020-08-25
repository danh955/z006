// <copyright file="UserDbContext.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Blazor.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Application database context class.
    /// </summary>
    public class UserDbContext : IdentityDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDbContext"/> class.
        /// </summary>
        /// <param name="options">DbContextOptions ApplicationDbContext.</param>
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {
        }
    }
}