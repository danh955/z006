﻿// <copyright file="HttpContextAccessorExtension.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Blazor.Extensions
{
    using System.Security.Claims;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// HTTP context accessor extension class.
    ///
    /// The IHttpContextAccessor needs to be registered as a service.
    /// services.AddHttpContextAccessor();.
    ///
    /// Usage in razor component:
    ///     @using Extensions
    ///     @inject Microsoft.AspNetCore.Http.IHttpContextAccessor accessor
    ///     User ID is @accessor.GetNameIdentifierClaim().
    /// </summary>
    public static class HttpContextAccessorExtension
    {
        /// <summary>
        /// Get name identifier claim.
        /// Same as get the user ID.
        /// </summary>
        /// <param name="accessor">IHttpContextAccessor.</param>
        /// <returns>The user ID.  Null if not found.</returns>
        public static string GetUserId(this IHttpContextAccessor accessor)
        {
            return accessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}