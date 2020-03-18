using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EflatunNakliyeTakip.EntityFrameworkCore
{
    [DependsOn(
        typeof(EflatunNakliyeTakipEntityFrameworkCoreModule)
        )]
    public class EflatunNakliyeTakipEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<EflatunNakliyeTakipMigrationsDbContext>();
        }
    }
}
