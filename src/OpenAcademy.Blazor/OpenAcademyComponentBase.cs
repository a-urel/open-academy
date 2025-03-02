using OpenAcademy.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OpenAcademy.Blazor;

public abstract class OpenAcademyComponentBase : AbpComponentBase
{
    protected OpenAcademyComponentBase()
    {
        LocalizationResource = typeof(OpenAcademyResource);
    }
}
