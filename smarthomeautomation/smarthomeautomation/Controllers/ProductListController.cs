using SmartBAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace smarthomeautomation.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        [Route("categories/{CategoryName}")]
        public ActionResult Index(string CategoryName)
        {
            SAPO.GetProduct getProduct = new SAPO.GetProduct();
            getProduct.Name = CategoryName.Replace("-", " ").Replace(".", "_");
            Retrieve<SAPO.GetProduct, SAPO.ProductsPro> retrieve = new Retrieve<SAPO.GetProduct, SAPO.ProductsPro>(new Products());
            List<SAPO.ProductsPro> products = new List<SAPO.ProductsPro>();
            products = retrieve.ListRetreive(getProduct);
            return View(products);
        }
        
        
    }
}