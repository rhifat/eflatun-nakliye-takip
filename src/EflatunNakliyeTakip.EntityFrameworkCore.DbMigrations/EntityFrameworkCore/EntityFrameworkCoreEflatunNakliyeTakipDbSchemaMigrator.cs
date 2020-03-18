using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EflatunNakliyeTakip.Data;
using Volo.Abp.DependencyInjection;

namespace EflatunNakliyeTakip.EntityFrameworkCore
{
    public class EntityFrameworkCoreEflatunNakliyeTakipDbSchemaMigrator
        : IEflatunNakliyeTakipDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEflatunNakliyeTakipDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EflatunNakliyeTakipMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EflatunNakliyeTakipMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}