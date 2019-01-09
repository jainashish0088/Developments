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
        public List<SAPO.ProductsPro> SelectProductList(string category)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            List<SAPO.ProductsPro> lstProductsPro = new List<ProductsPro>();
            var products = objSAContext.Categories.Where(c => c.Name.ToLower().Contains(category.ToLower())).Select(p => p.Products).ToList();
            return lstProductsPro;
        }

        public SAPO.ProductsPro SelectProductDetail(long Id)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            SAPO.ProductsPro product = new ProductsPro();
            var products = objSAContext.Products.Where(x => x.Id == Id).ToList();
            return product;
        }

        public void AddProduct(ProductsPro detail)
        {
            SAContext objSAContext = new SAContext();
            List<Product> lstProduct = new List<Product>();
            //var products = objSAContext.;
        }
        
    }
}
