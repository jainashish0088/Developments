using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smarthomeautomation.Controllers
{
    public class SharedController : Controller
    {
        // GET: Partial
        [ChildActionOnly]
        public ActionResult Header()
        {
            SAPO.Menu menu = new SAPO.Menu();
            return PartialView("_Header", menu);
        }
    }
}