using Microsoft.AspNetCore.Mvc;
using ProjektPortfolio_sr1630.DAL;
using ProjektPortfolio_sr1630.Models;
using System.Diagnostics;

namespace ProjektPortfolio_sr1630.Controllers
{
	public class HomeController : Controller
	{
		ProjectsContext db;

		public HomeController(ProjectsContext db)
		{
			this.db = db;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Projekty()
		{
			ViewBag.Projekty = db.Projects.ToList();

			return View(db.Projects.ToList());
		}

		public IActionResult StaticSites(string name)
		{
			return View(name);
		}

		
	}
}