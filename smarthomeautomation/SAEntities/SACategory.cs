using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class SACategory
    {
        public List<SAPO.Category> SelectMenu(SAPO.MenuRequest menuRequest)
        {
            SAContext objSAContext = new SAContext();
            List<SAPO.Category> lstCategory = new List<SAPO.Category>();
            var categories = objSAContext.Categories.Where(c => c.CategoryId == menuRequest.Id && c.IsActive == true && c.IsDeleted == false && c.IsShowOnCalculator == menuRequest.IsShowOnCalculator).ToList();
            foreach (var category in categories)
            {
                SAPO.Category _category = new SAPO.Category();
                _category.Id = category.Id;
                _category.CategoryId = category.CategoryId;
                _category.Desc = category.Desc;
                _category.LargeImg = category.LargeImg;
                _category.MetaDesc = category.MetaDesc;
                _category.MetaKeywords = category.MetaKeywords;
                _category.MetaTitle = category.MetaTitle;
                _category.Name = category.Name;
                _category.SequenceNumber = category.SequenceNumber;
                _category.ShortDesc = category.ShortDesc;
                _category.SmallImg = category.SmallImg;
                lstCategory.Add(_category);
            }
            return lstCategory;
        }
    }
}
