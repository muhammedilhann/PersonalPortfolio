using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Abstract.Manager
{
    public interface IRepositoryManager
    {
        IAboutRepository About { get; }
        IEducationRepository Education { get; }
        IExperienceRepository Experience { get; }
        void Save();
    }
}
