using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AuditLogging.MongoDB;
using Volo.Abp.BackgroundJobs.MongoDB;
using Volo.Abp.FeatureManagement.MongoDB;
using Volo.Abp.Identity.MongoDB;
using Volo.Abp.OpenIddict.MongoDB;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.MongoDB;
using Volo.Abp.SettingManagement.MongoDB;
using Volo.Abp.BlobStoring.Database.MongoDB;
using Volo.Abp.Uow;
using Volo.Abp.TextTemplateManagement.MongoDB;
using Volo.Saas.MongoDB;
using Volo.Abp.Gdpr;
using Volo.Abp.LanguageManagement.MongoDB;

namespace OpenAcademy.MongoDB;

[DependsOn(
    typeof(OpenAcademyDomainModule),
    typeof(AbpPermissionManagementMongoDbModule),
    typeof(AbpSettingManagementMongoDbModule),
    typeof(AbpBackgroundJobsMongoDbModule),
    typeof(AbpAuditLoggingMongoDbModule),
    typeof(AbpFeatureManagementMongoDbModule),
    typeof(AbpIdentityProMongoDbModule),
    typeof(AbpOpenIddictProMongoDbModule),
    typeof(LanguageManagementMongoDbModule),
    typeof(SaasMongoDbModule),
    typeof(TextTemplateManagementMongoDbModule),
    typeof(AbpGdprMongoDbModule),
    typeof(BlobStoringDatabaseMongoDbModule)
)]
public class OpenAcademyMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<OpenAcademyMongoDbContext>(options =>
        {
            options.AddDefaultRepositories();
        });

        context.Services.AddAlwaysDisableUnitOfWorkTransaction();
        Configure<AbpUnitOfWorkDefaultOptions>(options =>
        {
            options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
        });
    }
}
