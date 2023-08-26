using Microsoft.Extensions.DependencyInjection;
using PersonalPortfolio.Data.Repositories.Abstract.Manager;
using PersonalPortfolio.Data.Repositories.Abstract;
using PersonalPortfolio.Data.Repositories.Concrete.Manager;
using PersonalPortfolio.Data.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Extensions
{
    public static class RepositoryExtension
    {
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IEducationRepository, EducationRepository>();
            services.AddScoped<IExperienceRepository, ExperienceRepository>();
        }
    }
}
