using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPO;

namespace SmartBAL
{
    public class Brands : IAddModifier<SAPO.BrandInput>, IProduct<SAPO.BrandInput, SAPO.Brands>
    {
        public bool Add(SAPO.BrandInput detail)
        {
            throw new NotImplementedException();
        }

        public List<SAPO.Brands> ListRetreive(SAPO.BrandInput request)
        {
            List<SAPO.Brands> lstBrands = new List<SAPO.Brands>();
            SAEntities.DalBrands sABrand = new SAEntities.DalBrands();
            lstBrands = sABrand.SelectBrandList(request);
            return lstBrands;
        }

        public SAPO.Brands Retreive(SAPO.BrandInput request)
        {
            throw new NotImplementedException();
        }

        public bool Update(SAPO.BrandInput detail)
        {
            throw new NotImplementedException();
        }
    }
}
