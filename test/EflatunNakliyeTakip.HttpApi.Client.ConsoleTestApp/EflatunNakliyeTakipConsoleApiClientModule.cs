using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EflatunNakliyeTakip.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(EflatunNakliyeTakipHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class EflatunNakliyeTakipConsoleApiClientModule : AbpModule
    {
        
    }
}
