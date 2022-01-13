using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sapienza.Noticias.Data;
using Volo.Abp.DependencyInjection;

namespace Sapienza.Noticias.EntityFrameworkCore;

public class EntityFrameworkCoreNoticiasDbSchemaMigrator
    : INoticiasDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNoticiasDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NoticiasDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NoticiasDbContext>()
            .Database
            .MigrateAsync();
    }
}
