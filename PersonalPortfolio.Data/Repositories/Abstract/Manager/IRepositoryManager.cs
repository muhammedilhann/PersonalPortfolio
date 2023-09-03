using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Abstract.Manager
{
    public interface IRepositoryManager
    {
        IAboutRepository AboutRepository { get; }
        IEducationRepository EducationRepository { get; }
        IExperienceRepository ExperienceRepository { get; }
        void Save();
    }
}
