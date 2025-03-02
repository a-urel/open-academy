using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace OpenAcademy.MongoDB;

[DependsOn(
    typeof(OpenAcademyApplicationTestModule),
    typeof(OpenAcademyMongoDbModule)
)]
public class OpenAcademyMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = OpenAcademyMongoDbFixture.GetRandomConnectionString();
        });
    }
}
