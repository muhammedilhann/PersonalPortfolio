using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Web.Areas.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
