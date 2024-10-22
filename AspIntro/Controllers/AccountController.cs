using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
