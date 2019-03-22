using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class DalCalculator
    {
        public List<SAPO.CalculatorCategory> GetCalculatorCategory()
        {
            SAContext objSAContext = new SAContext();
            var lstCalculator = new List<SAPO.CalculatorCategory>();
            var calculatorCat = objSAContext.CalulatorCategory.Where(x => x.IsActive == true).ToList();
            foreach (var calc in calculatorCat)
            {
                var _category = new SAPO.CalculatorCategory();
                _category.Id = calc.Id;
                _category.Name = calc.Name;
                _category.MustAddInList = calc.MustAddInList;
                lstCalculator.Add(_category);
            }
            return lstCalculator;
        }
    }
}
