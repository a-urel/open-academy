using OpenAcademy.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OpenAcademy.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OpenAcademyController : AbpControllerBase
{
    protected OpenAcademyController()
    {
        LocalizationResource = typeof(OpenAcademyResource);
    }
}
