using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OpenAcademy.Data;

/* This is used if database provider does't define
 * IOpenAcademyDbSchemaMigrator implementation.
 */
public class NullOpenAcademyDbSchemaMigrator : IOpenAcademyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
