using SmartBAL;
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
            SAPO.MenuRequest menu = new SAPO.MenuRequest();
            Retrieve<SAPO.MenuRequest, SAPO.Category> retrieve = new Retrieve<SAPO.MenuRequest, SAPO.Category>(new Categories());
            List<SAPO.Category> categories = new List<SAPO.Category>();
            categories = retrieve.ListRetreive(menu);
            return PartialView("_Header", categories);
        }
    }
}