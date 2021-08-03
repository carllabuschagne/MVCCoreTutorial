using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreTutorial.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index(string ItemName)
		{
			//return View();
			return Content("This is the item: " + ItemName);
		}

	}
}
