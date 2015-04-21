using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daily_Performance.Controllers
{
    [Authorize]
    public class EditController : Controller
    {
        // GET: Edit
        public ActionResult EditInfo()
        {

            return View();
        }
    }
}