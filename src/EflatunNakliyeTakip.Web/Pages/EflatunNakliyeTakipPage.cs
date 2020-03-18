using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EflatunNakliyeTakip.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits EflatunNakliyeTakip.Web.Pages.EflatunNakliyeTakipPage
     */
    public abstract class EflatunNakliyeTakipPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<EflatunNakliyeTakipResource> L { get; set; }
    }
}
