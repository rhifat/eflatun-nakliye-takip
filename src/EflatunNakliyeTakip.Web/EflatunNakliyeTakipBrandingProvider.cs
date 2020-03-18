using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EflatunNakliyeTakip.Web
{
    [Dependency(ReplaceServices = true)]
    public class EflatunNakliyeTakipBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EflatunNakliyeTakip";
    }
}
