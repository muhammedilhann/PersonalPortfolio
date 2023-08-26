using PersonalPortfolio.Data.Context;
using PersonalPortfolio.Data.Repositories.Abstract;
using PersonalPortfolio.Data.Repositories.Concrete.Base;
using PersonalPortfolio.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Concrete
{
    public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository
    {
        public ExperienceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
