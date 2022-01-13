using Sapienza.Noticias.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Sapienza.Noticias.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NoticiasEntityFrameworkCoreModule),
    typeof(NoticiasApplicationContractsModule)
    )]
public class NoticiasDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
