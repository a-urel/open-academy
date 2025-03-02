using Microsoft.Extensions.Localization;
using OpenAcademy.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OpenAcademy.Blazor;

[Dependency(ReplaceServices = true)]
public class OpenAcademyBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<OpenAcademyResource> _localizer;

    public OpenAcademyBrandingProvider(IStringLocalizer<OpenAcademyResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
