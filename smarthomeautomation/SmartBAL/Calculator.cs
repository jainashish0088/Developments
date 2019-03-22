using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPO;

namespace SmartBAL
{
    public class Calculator : IProduct<SAPO.CalculatorCategory, SAPO.CalculatorCategory>
    {
        public List<CalculatorCategory> ListRetreive(CalculatorCategory request)
        {
            var calc = new SAEntities.DalCalculator();
            return calc.GetCalculatorCategory();
        }

        public CalculatorCategory Retreive(CalculatorCategory request)
        {
            throw new NotImplementedException();
        }
    }
}
