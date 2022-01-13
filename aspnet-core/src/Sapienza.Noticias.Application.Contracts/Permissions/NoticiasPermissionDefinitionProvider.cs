using Sapienza.Noticias.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Sapienza.Noticias.Permissions;

public class NoticiasPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NoticiasPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NoticiasPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NoticiasResource>(name);
    }
}
