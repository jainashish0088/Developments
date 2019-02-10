using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smarthomeautomation.Models
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            //Categories = new List<Models.Category>();
            Categories = new List<SAPO.Category>();
            Brands = new List<SAPO.Brands>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PropertyType { get; set; }
        public List<SAPO.Category> Categories { get; set; }
        public List<SAPO.Brands> Brands { get; set; }
    }
    public class Brand
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}