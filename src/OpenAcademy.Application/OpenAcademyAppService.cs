using OpenAcademy.Localization;
using Volo.Abp.Application.Services;

namespace OpenAcademy;

/* Inherit your application services from this class.
 */
public abstract class OpenAcademyAppService : ApplicationService
{
    protected OpenAcademyAppService()
    {
        LocalizationResource = typeof(OpenAcademyResource);
    }
}
