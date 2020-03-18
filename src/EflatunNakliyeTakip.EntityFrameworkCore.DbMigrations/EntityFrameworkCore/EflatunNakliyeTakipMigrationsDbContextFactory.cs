using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EflatunNakliyeTakip.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class EflatunNakliyeTakipMigrationsDbContextFactory : IDesignTimeDbContextFactory<EflatunNakliyeTakipMigrationsDbContext>
    {
        public EflatunNakliyeTakipMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<EflatunNakliyeTakipMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new EflatunNakliyeTakipMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
