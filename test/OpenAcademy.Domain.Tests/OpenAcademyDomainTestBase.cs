using Volo.Abp.Modularity;

namespace OpenAcademy;

/* Inherit from this class for your domain layer tests. */
public abstract class OpenAcademyDomainTestBase<TStartupModule> : OpenAcademyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
