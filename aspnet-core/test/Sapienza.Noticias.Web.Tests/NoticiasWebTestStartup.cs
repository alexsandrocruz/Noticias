using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Sapienza.Noticias;

public class NoticiasWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<NoticiasWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
