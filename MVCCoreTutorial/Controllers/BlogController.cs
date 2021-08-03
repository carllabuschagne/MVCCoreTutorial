using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreTutorial.Controllers
{
	public class BlogController : Controller
	{
		[Route("blogs/")]
		public IActionResult Index()
		{
			return Content("blogs list here");
		}

		[Route("blogs/{entryId}/{slug}")]
		[Route("blog/{entryId}/{slug}")]
		public IActionResult Blog(int entryId, string slug)
		{
			return Content("Blog entry with ID " + entryId.ToString() + " requested (URL Slug: " + slug + ")");
		}
	}
}
