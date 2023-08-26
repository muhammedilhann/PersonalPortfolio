using Microsoft.Extensions.DependencyInjection;
using PersonalPortfolio.Business.Services.Abstract;
using PersonalPortfolio.Business.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
        }
    }
}
