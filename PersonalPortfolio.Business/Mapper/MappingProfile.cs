using AutoMapper;
using PersonalPortfolio.Entities.Dtos;
using PersonalPortfolio.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Experience,ExperienceDto>().ReverseMap();
            CreateMap<Experience,ExperienceAddDto>().ReverseMap();
        }
    }
}
