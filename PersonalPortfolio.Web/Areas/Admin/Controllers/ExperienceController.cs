using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PersonalPortfolio.Business.Services.Abstract;
using PersonalPortfolio.Entities.Dtos;
using PersonalPortfolio.Entities.Entities;

namespace PersonalPortfolio.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly IServiceManager _service;

        public ExperienceController(IServiceManager service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetExperienceData()
        {
            var experiences = _service.ExperienceService.GetAll();
            return Json(new
            {
                data = experiences,
            });
        }
        [HttpGet]
        public IActionResult AddModal()
        {
            return PartialView("_PartialAdd",new ExperienceDto());
        }
        [HttpPost]
        public JsonResult AddExperience(string expAddData)
        { 
            var experienceAdd = JsonConvert.DeserializeObject<ExperienceAddDto>(expAddData);
            var experience = _service.ExperienceService.Add(experienceAdd);
            return Json(new
            {
                data = experience,
            });
        }
        [HttpGet]
        public IActionResult UpdateModal(int id)
        {
            var experienceDetail = _service.ExperienceService.Get(id);
            return PartialView("_PartialUpdate", experienceDetail);
        }
        [HttpPost]
        public JsonResult UpdateExperience(string expUpdateData)
        {
            var experienceUpdate = JsonConvert.DeserializeObject<ExperienceDto>(expUpdateData);
            var experience = _service.ExperienceService.Update(experienceUpdate);
            return Json(new
            {
                data = experience,
            });
        }
        [HttpPost]
        public JsonResult DeleteExperience(int id)
        {
            var experienceDetail = _service.ExperienceService.Get(id);
            var experience = _service.ExperienceService.Delete(experienceDetail);
            return Json(new
            {
                data = experience,
            });
        }
    }
}
