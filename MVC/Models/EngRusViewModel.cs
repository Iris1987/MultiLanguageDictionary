using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class EngRusViewModel
    {
        public int IdTranslation { get; set; }
        public int IdWordEng { get; set; }
        public int IdWordRus { get; set; }
        public int? IdCategory { get; set; }
        public int? IdPart { get; set; }
        public string Example { get; set; }

        public Subcategory IdCategoryNavigation { get; set; }
        public PartOfSpeech IdPartNavigation { get; set; }
        public LangEnglish IdWordEngNavigation { get; set; }
        public LangRussian IdWordRusNavigation { get; set; }
    }
}
