using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class SubcategoryViewModel
    {
       

        public int IdSubcategory { get; set; }
        public string Subcategoryname { get; set; }
        public int IdCategory { get; set; }

        public CategoryViewModel IdCategoryNavigation { get; set; }
        public ICollection<EngEstViewModel> TranslationEngEst { get; set; }
        public ICollection<EngRusViewModel> TranslationEngRus { get; set; }
        public ICollection<RusEstViewModel> TranslationRusEst { get; set; }
    }
}
