using SmartBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smarthomeautomation.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            SAPO.MenuRequest menu = new SAPO.MenuRequest();
            menu.IsShowOnCalculator = true;
            Retrieve<SAPO.MenuRequest, SAPO.Category> retrieve = new Retrieve<SAPO.MenuRequest, SAPO.Category>(new Categories());
            List<SAPO.Category> categories = new List<SAPO.Category>();
            categories = retrieve.ListRetreive(menu);
            return View(categories);
        }
        public ActionResult Index(string category,string brands)
        {
            TempData["tdCategory"] = category;
            TempData["tdBrands"] = brands;
            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public ActionResult Brands()
        {
            SAPO.BrandInput brand = new SAPO.BrandInput();
            Retrieve<SAPO.BrandInput, SAPO.Brands> retrieve = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            List<SAPO.Brands> lstbrands = new List<SAPO.Brands>();
            lstbrands = retrieve.ListRetreive(brand);
            return Json(lstbrands, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductList()
        {
            ViewBag.category=TempData["tdCategory"];
            ViewBag.brands= TempData["tdBrands"];
            return View("ProductList");
        }
        [HttpPost]
        public ActionResult ProductList(string CategoryName, string BrandName)  
        {
            SAPO.GetProduct getProduct = new SAPO.GetProduct();
            getProduct.CategoryName = CategoryName;
            getProduct.BrandName = BrandName;
            Retrieve<SAPO.GetProduct, SAPO.ProductsPro> retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            List<SAPO.ProductsPro> products = new List<SAPO.ProductsPro>();
            products = retrieve.ListRetreive(getProduct);
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}