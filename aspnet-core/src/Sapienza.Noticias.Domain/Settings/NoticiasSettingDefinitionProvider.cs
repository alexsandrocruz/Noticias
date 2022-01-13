using Volo.Abp.Settings;

namespace Sapienza.Noticias.Settings;

public class NoticiasSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NoticiasSettings.MySetting1));
    }
}
