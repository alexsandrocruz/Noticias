using Sapienza.Noticias.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sapienza.Noticias.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class NoticiasPageModel : AbpPageModel
{
    protected NoticiasPageModel()
    {
        LocalizationResourceType = typeof(NoticiasResource);
    }
}
