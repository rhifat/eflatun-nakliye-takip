using Volo.Abp.Modularity;

namespace EflatunNakliyeTakip
{
    [DependsOn(
        typeof(EflatunNakliyeTakipApplicationModule),
        typeof(EflatunNakliyeTakipDomainTestModule)
        )]
    public class EflatunNakliyeTakipApplicationTestModule : AbpModule
    {

    }
}