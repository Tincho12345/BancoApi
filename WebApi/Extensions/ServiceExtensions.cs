﻿using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApiVersionExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
