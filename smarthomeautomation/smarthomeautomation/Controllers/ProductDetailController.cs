using SmartBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smarthomeautomation.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        [Route("products/{productName}")]
        public ActionResult Index(string productName)
        {
            SAPO.GetProduct getProduct = new SAPO.GetProduct();
            getProduct.Name = productName.Replace("-", " ").Replace("_", ".");
            var retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            var products = new SAPO.ProductsPro();
            products = retrieve.Retreive(getProduct);
            return View(products);
        }
    }
}