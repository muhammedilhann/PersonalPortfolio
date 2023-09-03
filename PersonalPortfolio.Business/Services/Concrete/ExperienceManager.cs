using AutoMapper;
using PersonalPortfolio.Business.Services.Abstract;
using PersonalPortfolio.Data.Repositories.Abstract.Manager;
using PersonalPortfolio.Entities.Dtos;
using PersonalPortfolio.Entities.Entities;
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
            var experince = _manager.ExperienceRepository.GetAll(false);
         
            return _mapper.Map<List<ExperienceDto>>(experince);
        }
        public ExperienceAddDto Add(ExperienceAddDto expAddDto)
        {
            var experince = _mapper.Map<Experience>(expAddDto);
            try
            {
                _manager.ExperienceRepository.Create(experince);
                _manager.Save();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return _mapper.Map<ExperienceAddDto>(experince); ;
        }
        public ExperienceDto Get(int Id)
        {
            var experince = _manager.ExperienceRepository.GetBy(x=>x.Id == Id,false);
            return _mapper.Map<ExperienceDto>(experince);
        }
        public ExperienceDto Update(ExperienceDto expUpdateDto)
        {
            var experince = _mapper.Map<Experience>(expUpdateDto);
            try
            {
                _manager.ExperienceRepository.Update(experince);
                _manager.Save();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return expUpdateDto;
        }
        public ExperienceDto Delete(ExperienceDto expDeleteDto)
        {
            var experince = _mapper.Map<Experience>(expDeleteDto);
            try
            {
                _manager.ExperienceRepository.Delete(experince);
                _manager.Save();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return expDeleteDto;
        }
    }
}
