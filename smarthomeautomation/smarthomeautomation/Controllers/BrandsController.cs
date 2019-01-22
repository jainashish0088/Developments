using SmartBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smarthomeautomation.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        [Route("~/brands/{brandName}")]
        public ActionResult Index(string brandName)
        {
            SAPO.GetProduct getProduct = new SAPO.GetProduct();
            getProduct.BrandName = brandName.Replace("-", " ").Replace(".", "_");
            Retrieve<SAPO.GetProduct, SAPO.ProductsPro> retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            List<SAPO.ProductsPro> products = new List<SAPO.ProductsPro>();
            products = retrieve.ListRetreive(getProduct);
            return View("~/Views/ProductList/Index.cshtml", products);
        }
    }
}