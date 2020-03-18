using EflatunNakliyeTakip.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EflatunNakliyeTakip.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class EflatunNakliyeTakipPageModel : AbpPageModel
    {
        protected EflatunNakliyeTakipPageModel()
        {
            LocalizationResourceType = typeof(EflatunNakliyeTakipResource);
        }
    }
}