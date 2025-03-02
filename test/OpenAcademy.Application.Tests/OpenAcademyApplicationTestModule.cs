using Volo.Abp.Modularity;

namespace OpenAcademy;

[DependsOn(
    typeof(OpenAcademyApplicationModule),
    typeof(OpenAcademyDomainTestModule)
)]
public class OpenAcademyApplicationTestModule : AbpModule
{

}
