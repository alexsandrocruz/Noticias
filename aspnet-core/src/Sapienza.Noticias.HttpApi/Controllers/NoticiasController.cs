using Sapienza.Noticias.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sapienza.Noticias.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NoticiasController : AbpControllerBase
{
    protected NoticiasController()
    {
        LocalizationResource = typeof(NoticiasResource);
    }
}
