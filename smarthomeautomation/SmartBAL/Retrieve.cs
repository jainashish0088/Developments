using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBAL
{
    public class Retrieve<T, T1>
    {
        private readonly IProduct<T, T1> _product;
        public Retrieve(IProduct<T, T1> product)
        {
            _product = product;
        }
        public List<T1> ListRetreive(T request)
        {
            List<T1> list = new List<T1>();
            list = _product.ListRetreive(request);
            return list;
        }
        public T1 Retreive(T request)
        {
            return _product.Retreive(request);
        }
    }
}
