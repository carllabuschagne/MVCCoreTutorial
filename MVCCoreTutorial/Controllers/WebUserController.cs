using Microsoft.AspNetCore.Mvc;
using MVCCoreTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreTutorial.Controllers
{
	public class WebUserController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			WebUser wu = new WebUser();
			wu.FirstName = "";
			wu.LastName = "";
			wu.Countries = new List<string>()
												{
													"USA",
													"Great Britain",
													"Germany"
												};
			return View(wu);
		}

		[HttpPost]
		public IActionResult Index(WebUser wu)
		{
			if (ModelState.IsValid)
			{
				//Model state is valid
				return Json(wu);
			}
			else
			{
				//Model state is Invalid
				//return Content("Model state is invalid");
				return View(wu);
			}



		}

	}
}
