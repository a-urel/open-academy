using Volo.Abp.Modularity;

namespace OpenAcademy;

public abstract class OpenAcademyApplicationTestBase<TStartupModule> : OpenAcademyTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
