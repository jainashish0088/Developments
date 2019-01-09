using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPO;

namespace SmartBAL
{
    public class Categories : IAddModifier, IProduct<SAPO.GetProduct, SAPO.ProductsPro>
    {
        public bool Add<T>(T detail)
        {
            throw new NotImplementedException();
        }

        public List<ProductsPro> ListRetreive(GetProduct request)
        {
            throw new NotImplementedException();
        }

        public ProductsPro Retreive(GetProduct request)
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T detail)
        {
            throw new NotImplementedException();
        }
    }
}
