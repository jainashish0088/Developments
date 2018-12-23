using SAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    public class Products : IAddModifier
    {
        public bool Add<ProductsPro>(ProductsPro detail)
        {
            DalProduct objDalProduct = new DalProduct();
            return objDalProduct.Add(detail);
        }

        public bool Update<ProductsPro>(ProductsPro detail)
        {
            return true;
        }
    }
}
