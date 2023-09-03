using PersonalPortfolio.Business.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Services.Concrete
{
    public class ServiceManager : IServiceManager
    {
        private readonly IExperienceService _experienceManager;

        public ServiceManager(IExperienceService experienceManager)
        {
            _experienceManager = experienceManager;
        }

        public IExperienceService ExperienceService => _experienceManager;
    }
}
