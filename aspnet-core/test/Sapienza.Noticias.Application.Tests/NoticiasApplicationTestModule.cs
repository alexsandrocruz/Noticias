using Volo.Abp.Modularity;

namespace Sapienza.Noticias;

[DependsOn(
    typeof(NoticiasApplicationModule),
    typeof(NoticiasDomainTestModule)
    )]
public class NoticiasApplicationTestModule : AbpModule
{

}
