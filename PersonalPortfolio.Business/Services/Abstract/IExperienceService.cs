using PersonalPortfolio.Entities.Dtos;
using PersonalPortfolio.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Business.Services.Abstract
{
    public interface IExperienceService
    {
        List<ExperienceDto> GetAll();
        ExperienceAddDto Add(ExperienceAddDto experienceDto);
        ExperienceDto Get(int Id);
        ExperienceDto Update(ExperienceDto expUpdateDto);
        ExperienceDto Delete(ExperienceDto expDeleteDto);
    }
}
