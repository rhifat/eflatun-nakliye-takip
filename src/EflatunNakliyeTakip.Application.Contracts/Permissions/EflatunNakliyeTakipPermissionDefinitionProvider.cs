using EflatunNakliyeTakip.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EflatunNakliyeTakip.Permissions
{
    public class EflatunNakliyeTakipPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(EflatunNakliyeTakipPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(EflatunNakliyeTakipPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EflatunNakliyeTakipResource>(name);
        }
    }
}
