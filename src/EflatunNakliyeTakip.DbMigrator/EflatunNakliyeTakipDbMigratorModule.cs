using EflatunNakliyeTakip.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EflatunNakliyeTakip.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EflatunNakliyeTakipEntityFrameworkCoreDbMigrationsModule),
        typeof(EflatunNakliyeTakipApplicationContractsModule)
        )]
    public class EflatunNakliyeTakipDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
