using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOC.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Dedicated to Darth Cheech the Wise D&D Characters.";

			return View();
		}

		public ActionResult Skills()
		{
			ViewBag.Message = "Your characters skill set.";

			return View();
		}

		

		//public ActionResult CharProfile()
		//{
		//	ViewBag.Message = "Character Profile.";

		//	return CharProfile();
		//}



	}


}