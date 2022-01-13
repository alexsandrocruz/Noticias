using Sapienza.Noticias.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Sapienza.Noticias;

[DependsOn(
    typeof(NoticiasEntityFrameworkCoreTestModule)
    )]
public class NoticiasDomainTestModule : AbpModule
{

}
