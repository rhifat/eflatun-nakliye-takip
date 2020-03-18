using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EflatunNakliyeTakip.Localization;
using EflatunNakliyeTakip.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace EflatunNakliyeTakip.Web.Menus
{
    public class EflatunNakliyeTakipMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<EflatunNakliyeTakipResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("EflatunNakliyeTakip.Home", l["Menu:Home"], "/"));
            //<-- added the below code
            context.Menu.AddItem(
                new ApplicationMenuItem("Giderler", l["Menu:Gider"])
                    .AddItem(
                        new ApplicationMenuItem("EflatunNakliyeTakip.Giderler", l["Menu:Giderler"], url: "/Giderler")
                    )
            );
            context.Menu.AddItem(
                new ApplicationMenuItem("Giderler", l["Menu:Gelir"])
                    .AddItem(
                        new ApplicationMenuItem("EflatunNakliyeTakip.Giderler", l["Menu:Gelirler"], url: "/Gelirler")
                    )
            );
            //-->
        }
    }
}
