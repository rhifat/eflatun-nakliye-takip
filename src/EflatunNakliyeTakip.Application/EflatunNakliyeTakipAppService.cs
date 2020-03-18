using System;
using System.Collections.Generic;
using System.Text;
using EflatunNakliyeTakip.Localization;
using Volo.Abp.Application.Services;

namespace EflatunNakliyeTakip
{
    /* Inherit your application services from this class.
     */
    public abstract class EflatunNakliyeTakipAppService : ApplicationService
    {
        protected EflatunNakliyeTakipAppService()
        {
            LocalizationResource = typeof(EflatunNakliyeTakipResource);
        }
    }
}
