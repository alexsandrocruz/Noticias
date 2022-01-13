using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Sapienza.Noticias.Web;

[Dependency(ReplaceServices = true)]
public class NoticiasBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Noticias";
}
