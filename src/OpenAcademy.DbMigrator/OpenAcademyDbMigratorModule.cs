using OpenAcademy.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OpenAcademy.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OpenAcademyMongoDbModule),
    typeof(OpenAcademyApplicationContractsModule)
)]
public class OpenAcademyDbMigratorModule : AbpModule
{
}
