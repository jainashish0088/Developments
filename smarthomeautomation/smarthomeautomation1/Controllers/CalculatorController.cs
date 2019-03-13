using SAEntities;
using SmartBAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            var calculatorModel = new Models.CalculatorModel();
            var menu = new SAPO.MenuRequest();
            menu.IsShowOnCalculator = true;

            var retrieveCategories = new Retrieve<SAPO.MenuRequest, SAPO.Category>(new Categories());
            calculatorModel.Categories = retrieveCategories.ListRetreive(menu);

            var brand = new SAPO.BrandInput();
            var retrievebrand = new Retrieve<SAPO.BrandInput, SAPO.Brands>(new SmartBAL.Brands());
            calculatorModel.Brands = retrievebrand.ListRetreive(brand);


            return View(calculatorModel);
        }
        [HttpPost]
        public ActionResult Index(Models.CalculatorModel calculatorModel)
        {
            Session["calculatorModel"] = calculatorModel;
            return RedirectToAction("ProductList");
        }
        public ActionResult ProductList()
        {
            var calculatorModel = (Models.CalculatorModel)(Session["calculatorModel"]);
            if (calculatorModel == null)
                return HttpNotFound();
            //var getProduct = new SAPO.GetProduct();
            //if (calculatorModel.Categories.Count > 0)
            //    getProduct.CategoryName = calculatorModel.Categories[0].Name;
            //if (calculatorModel.Brands.Count > 0)
            //    getProduct.BrandIds = calculatorModel.Brands;
            //Retrieve<SAPO.GetProduct, SAPO.ProductsPro> retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            //List<SAPO.ProductsPro> products = new List<SAPO.ProductsPro>();
            //products = retrieve.ListRetreive(getProduct);
            return View(calculatorModel);
        }
        [HttpPost]
        public ActionResult Products(Models.CalculatorModel calculatorModel)
        {
            var getProduct = new SAPO.GetProduct();
            if (calculatorModel.Categories.Count > 0)
                getProduct.CategoryName = calculatorModel.Categories[0].Name;
            if (calculatorModel.Brands.Count > 0)
                getProduct.BrandIds = calculatorModel.Brands;
            Retrieve<SAPO.GetProduct, SAPO.ProductsPro> retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            List<SAPO.ProductsPro> products = new List<SAPO.ProductsPro>();
            products = retrieve.ListRetreive(getProduct);
            return Json(products, JsonRequestBehavior.AllowGet);
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