using System.Threading.Tasks;

namespace OpenAcademy.Data;

public interface IOpenAcademyDbSchemaMigrator
{
    Task MigrateAsync();
}
