using EntityFrameWork1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork1.Controllers
{
	public class FormController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Registration()
		{
			Form form = new Form();
			return View(form);
		}

		[HttpPost]

		public IActionResult Registration(Form form)
		{
			if(ModelState.IsValid==true)

			{
				BrightDb1Context db = new BrightDb1Context();
				db.Forms.Add(form);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(form);
		}
	}
}
