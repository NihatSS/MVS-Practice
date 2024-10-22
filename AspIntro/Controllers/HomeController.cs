using AspIntro.Models;
using AspIntro.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			List<Student> students = new()
			{
				new()
				{
					Id = 1,
					FullName = "Eli Veliyev",
					Age = 25,
					Address = "Ehmedli"
				},
				new()
				{
					Id = 2,
					FullName = "Lionel Messi",
					Age = 38,
					Address = "Sabuncu"
				},
				new()
				{
					Id = 3,
					FullName = "Cristiano Ronaldo",
					Age = 25,
					Address = "Yasamal"
				}
			};


			List<StudentVM> model = new();

            foreach (var item in students)
            {
				model.Add(new()
				{
					FullName = item.FullName,
					Age = item.Age,
				});
            }



            //Student student = new()
            //{
            //	Id = 2,
            //	FullName = "Lionel Messi",
            //	Age = 38,
            //	Address = "Sabuncu"
            //};

            //StudentVM model = new()
            //{
            //	FullName = student.FullName,
            //	Age = student.Age,
            //};


            return View(model);
        }
    }
}
