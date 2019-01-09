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
            //DalProduct objDalProduct = new DalProduct();
            //objDalProduct.SelectProductList(CategoryName);
            return View();
        }
        
        
    }
}