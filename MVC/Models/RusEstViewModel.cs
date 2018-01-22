using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class RusEstViewModel
    {
        public int IdTranslation { get; set; }
        public int IdWordRus { get; set; }
        public int IdWordEst { get; set; }
        public int? IdCategory { get; set; }
        public int? IdPart { get; set; }
        public string Example { get; set; }

        public SubcategoryViewModel IdCategoryNavigation { get; set; }
        public PartOfSpeechViewModel IdPartNavigation { get; set; }
        public EstViewModel IdWordEstNavigation { get; set; }
        public RusViewModel IdWordRusNavigation { get; set; }
    }
}
