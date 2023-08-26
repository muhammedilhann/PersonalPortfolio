using AutoMapper;
using PersonalPortfolio.Business.Services.Abstract;
using PersonalPortfolio.Data.Repositories.Abstract.Manager;
using PersonalPortfolio.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Services.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;

        public ExperienceManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public List<ExperienceDto> GetAll()
        {
            var experince = _manager.Experience.GetAll(false);
            return _mapper.Map<List<ExperienceDto>>(experince);
        }
    }
}
