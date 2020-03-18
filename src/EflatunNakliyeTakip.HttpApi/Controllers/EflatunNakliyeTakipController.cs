using EflatunNakliyeTakip.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EflatunNakliyeTakip.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EflatunNakliyeTakipController : AbpController
    {
        protected EflatunNakliyeTakipController()
        {
            LocalizationResource = typeof(EflatunNakliyeTakipResource);
        }
    }
}