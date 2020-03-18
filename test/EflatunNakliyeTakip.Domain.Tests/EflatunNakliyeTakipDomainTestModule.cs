using EflatunNakliyeTakip.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EflatunNakliyeTakip
{
    [DependsOn(
        typeof(EflatunNakliyeTakipEntityFrameworkCoreTestModule)
        )]
    public class EflatunNakliyeTakipDomainTestModule : AbpModule
    {

    }
}