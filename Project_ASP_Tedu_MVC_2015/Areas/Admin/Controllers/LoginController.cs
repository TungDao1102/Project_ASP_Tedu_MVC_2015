using Microsoft.AspNetCore.Mvc;
using Models;
using Project_ASP_Tedu_MVC_2015.Areas.Admin.Code;
using Project_ASP_Tedu_MVC_2015.Areas.Admin.Models;

namespace Project_ASP_Tedu_MVC_2015.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class LoginController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.Password);
            if (result && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
    }
}
