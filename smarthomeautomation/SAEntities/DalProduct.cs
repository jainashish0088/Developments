using SAPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class DalProduct
    {
        public void SelectProductList(string category)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            var products = objSAContext.Categories.Where(c => c.Name.ToLower().Contains(category.ToLower())).Select(p => p.Products).ToList();
        }

        public void AddProduct(ProductsPro detail)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            var products = objSAContext.;
        }
    }
}
