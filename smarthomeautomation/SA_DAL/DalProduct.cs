using SAEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_DAL
{
    public class DalProduct
    {
        public void SelectProductList(string category)
        {
            SAContext objSAContext = new SAContext();
            var studentList =
                from c in objSAContext.Products
                where c.Id == 1
                select c;
        }
    }
}
