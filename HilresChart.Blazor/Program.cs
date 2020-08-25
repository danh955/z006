// <copyright file="Program.cs" company="Hilres">
// Copyright (c) Hilres. All rights reserved.
// </copyright>

namespace HilresChart.Blazor
{
    using System;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using Serilog;

    /// <summary>
    /// Main program class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Start of main program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>1 if error. Otherwise good.</returns>
        public static int Main(string[] args)
        {
            SetupSerilog();
            try
            {
                Log.Information(" -=-=-=-=-=- Application START -=-=-=-=-=-");
                CreateHostBuilder(args).Build().Run();
                return 0;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                Log.Fatal("Fatal Error: {0}", e.Message);
                return 1;
            }
            finally
            {
                Log.Information(" -=-=-=-=-=- Application END -=-=-=-=-=-");
                Log.CloseAndFlush();
            }
        }

        /// <summary>
        /// CreateHost builder.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>IHostBuilder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        /// <summary>
        /// Setup Serilog.
        /// </summary>
        private static void SetupSerilog()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }
    }
}