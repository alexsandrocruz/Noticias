using System.Threading.Tasks;

namespace Sapienza.Noticias.Data;

public interface INoticiasDbSchemaMigrator
{
    Task MigrateAsync();
}
