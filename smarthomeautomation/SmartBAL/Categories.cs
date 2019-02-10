using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPO;

namespace SmartBAL
{
    public class Categories : IAddModifier<GetProduct>, IProduct<SAPO.MenuRequest, SAPO.Category>
    {
        public bool Add(GetProduct detail)
        {
            throw new NotImplementedException();
        }

        public List<SAPO.Category> ListRetreive(SAPO.MenuRequest request)
        {
            List<SAPO.Category> lstCategory = new List<Category>();
            SAEntities.SACategory sACategory = new SAEntities.SACategory();
            lstCategory = sACategory.SelectMenu(request);
            return lstCategory;
        }

        public SAPO.Category Retreive(SAPO.MenuRequest request)
        {
            throw new NotImplementedException();
        }

        public bool Update(GetProduct detail)
        {
            throw new NotImplementedException();
        }
    }
    public class Myclass<MyString>
    {

    }
    public class test
    {
        public void tesing()
        {
            var obj = new Myclass<MyString>();
        }
        
    }
    class MyString
    {
        static MyString()
        {

        }   
    }
}
