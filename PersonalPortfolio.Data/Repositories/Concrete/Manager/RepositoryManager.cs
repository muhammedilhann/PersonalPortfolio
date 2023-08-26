using PersonalPortfolio.Data.Context;
using PersonalPortfolio.Data.Repositories.Abstract.Manager;
using PersonalPortfolio.Data.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Concrete.Manager
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly IEducationRepository _educationRepository;
        private readonly IExperienceRepository _experienceRepository;
        private readonly IAboutRepository _aboutRepository;

        public RepositoryManager(AppDbContext context, IAboutRepository aboutRepository, IEducationRepository educationRepository, IExperienceRepository experienceRepository)
        {
            _context = context;
            _aboutRepository = aboutRepository;
            _educationRepository = educationRepository;
            _experienceRepository = experienceRepository;
        }
        public IAboutRepository About => _aboutRepository;
        public IEducationRepository Education => _educationRepository;

        public IExperienceRepository Experience => _experienceRepository;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
