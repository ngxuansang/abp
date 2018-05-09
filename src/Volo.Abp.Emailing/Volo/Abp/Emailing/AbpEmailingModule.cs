﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Volo.Abp.Emailing
{
    public class AbpEmailingModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddAssemblyOf<AbpEmailingModule>();
        }
    }
}
