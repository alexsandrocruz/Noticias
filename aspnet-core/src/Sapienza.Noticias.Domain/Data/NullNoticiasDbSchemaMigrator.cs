using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Sapienza.Noticias.Data;

/* This is used if database provider does't define
 * INoticiasDbSchemaMigrator implementation.
 */
public class NullNoticiasDbSchemaMigrator : INoticiasDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
