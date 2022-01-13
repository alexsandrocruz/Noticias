using System;
using System.Collections.Generic;
using System.Text;
using Sapienza.Noticias.Localization;
using Volo.Abp.Application.Services;

namespace Sapienza.Noticias;

/* Inherit your application services from this class.
 */
public abstract class NoticiasAppService : ApplicationService
{
    protected NoticiasAppService()
    {
        LocalizationResource = typeof(NoticiasResource);
    }
}
