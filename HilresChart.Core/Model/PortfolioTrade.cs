// <copyright file="PortfolioTrade.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Core.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Portfolio trade class.
    /// </summary>
    public class PortfolioTrade
    {
        /// <summary>
        /// Gets or sets symbol.
        /// </summary>
        [Required]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets long name of the stock.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets trade action.
        /// </summary>
        public TradeAction TradeAction { get; set; }

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets entry date.
        /// </summary>
        public DateTime EntryDate { get; set; }

        /// <summary>
        /// Gets or sets entry price.
        /// </summary>
        public decimal EntryPrice { get; set; }

        /// <summary>
        /// Gets or sets exit date.
        /// </summary>
        public DateTime ExitDate { get; set; }

        /// <summary>
        /// Gets or sets exit price.
        /// </summary>
        public decimal ExitPrice { get; set; }
    }
}