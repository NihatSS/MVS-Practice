using AspIntro.Models;
using AspIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{

			Student student = new()
			{
				Id = 1,
				FullName = "Aqil Kazimov",
				Age = 29,
				Address = "Ehmedli"
			};

			Teacher teacher = new()
			{
				Id=1,
				FullName = "Cavid Bashirov"
			};

			//HomeVM model = new()
			//{
			//	Student = student,
			//	Teacher = teacher,
			//	UserName = "Nihat"
			//};

			return View();
		}
	}
}
