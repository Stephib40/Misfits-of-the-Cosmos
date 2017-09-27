using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MOC.Models
{
    public class MOCController : Controller
    {
        // GET: MOC
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult CharProfile()
		{
			ViewBag.Message = "Character Profile.";

			return CharProfile();
		}

	}
}