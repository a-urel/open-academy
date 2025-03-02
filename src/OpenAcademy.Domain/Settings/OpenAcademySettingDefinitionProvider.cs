using Volo.Abp.Settings;

namespace OpenAcademy.Settings;

public class OpenAcademySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OpenAcademySettings.MySetting1));
    }
}
