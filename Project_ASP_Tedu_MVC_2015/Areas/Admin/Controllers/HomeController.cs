using Microsoft.AspNetCore.Mvc;

namespace Project_ASP_Tedu_MVC_2015.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
