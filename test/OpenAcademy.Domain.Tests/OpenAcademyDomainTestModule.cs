using Volo.Abp.Modularity;

namespace OpenAcademy;

[DependsOn(
    typeof(OpenAcademyDomainModule),
    typeof(OpenAcademyTestBaseModule)
)]
public class OpenAcademyDomainTestModule : AbpModule
{

}
