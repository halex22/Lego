using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego
{
    internal static class AppConfig
    {
        public static IConfiguration Configuration { get; set; }
        // Scaffold-DbContext "Host=localhost;Port=5432;Database=Lego;Username=postgres;Password=secret;" Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models

        static AppConfig()
        {
            if (Configuration == null)
            {
                Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", false)
                .Build();
            }
        }


        public static string? GetConfigurationString() => Configuration.GetConnectionString("postgres");

    }
}
