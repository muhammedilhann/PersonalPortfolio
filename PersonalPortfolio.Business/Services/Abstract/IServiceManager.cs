using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Services.Abstract
{
    public interface IServiceManager
    {
        IExperienceService ExperienceService { get; }
    }
}
