using SAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPO;

namespace SmartBAL
{
    public class Products : IAddModifier<ProductsPro>, IProduct<SAPO.GetProduct, SAPO.ProductsPro>
    {
        public bool Add(ProductsPro detail)
        {
            DalProduct objDalProduct = new DalProduct();
            return true;// objDalProduct.AddProduct(detail);
        }

        public List<ProductsPro> ListRetreive(GetProduct request)
        {
            List<ProductsPro> lstProductsPro = new List<ProductsPro>();
            DalProduct objDalProduct = new DalProduct();
            lstProductsPro = objDalProduct.SelectProductList(request.Name);
            return lstProductsPro;
        }

        public ProductsPro Retreive(GetProduct request)
        {
            var product = new ProductsPro();
            var objDalProduct = new DalProduct();
            product = objDalProduct.SelectProductDetail(request.Name.ToLower().Replace("-", " "));
            return product;
        }

        public bool Update(ProductsPro detail)
        {
            return true;
        }
    }
}
