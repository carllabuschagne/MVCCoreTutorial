using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCoreTutorial.Models;

namespace MVCCoreTutorial.Controllers
{
	public class YoloController : Controller
	{
		public IActionResult Index()
		{
			Yolo yolo = new Yolo();

			yolo.ID = 1;
			yolo.YoloMessage = "Yo only live oop";

			return View(yolo);
		}
	}
}
