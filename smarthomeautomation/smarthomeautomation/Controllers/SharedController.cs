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
        [OutputCache(Duration = 100)]
        public ActionResult Header()
        {
            SAPO.MenuRequest menu = new SAPO.MenuRequest();
            Retrieve<SAPO.MenuRequest, SAPO.Category> retrieve = new Retrieve<SAPO.MenuRequest, SAPO.Category>(new Categories());
            List<SAPO.Category> categories = new List<SAPO.Category>();
            categories = retrieve.ListRetreive(menu);
            return PartialView("_Header", categories);
        }
        public ActionResult Brands()
        {
            SAPO.BrandInput brand = new SAPO.BrandInput();
            Retrieve<SAPO.BrandInput, SAPO.Brands> retrieve = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            List<SAPO.Brands> lstbrands = new List<SAPO.Brands>();
            lstbrands = retrieve.ListRetreive(brand);
            return PartialView("_Brands", lstbrands);
        }
        public ActionResult TopSeller()
        {
            SAPO.BrandInput brand = new SAPO.BrandInput();
            Retrieve<SAPO.BrandInput, SAPO.Brands> retrieve = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            List<SAPO.Brands> lstbrands = new List<SAPO.Brands>();
            lstbrands = retrieve.ListRetreive(brand);
            return PartialView("_TopSeller", lstbrands);
        }
        public ActionResult PopularProducts()
        {
            SAPO.BrandInput brand = new SAPO.BrandInput();
            Retrieve<SAPO.BrandInput, SAPO.Brands> retrieve = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            List<SAPO.Brands> lstbrands = new List<SAPO.Brands>();
            lstbrands = retrieve.ListRetreive(brand);
            return PartialView("_PopularProducts", lstbrands);
        }
        public ActionResult FeaturedCategory()
        {
            SAPO.BrandInput brand = new SAPO.BrandInput();
            Retrieve<SAPO.BrandInput, SAPO.Brands> retrieve = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            List<SAPO.Brands> lstbrands = new List<SAPO.Brands>();
            lstbrands = retrieve.ListRetreive(brand);
            return PartialView("_FeaturedCategory", lstbrands);
        }
    }
}