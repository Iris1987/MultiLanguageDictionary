using BaseEntities.Models;
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

        public SubcategoryViewModel IdCategoryNavigation { get; set; }
        public PartOfSpeechViewModel IdPartNavigation { get; set; }
        public EngViewModel IdWordEngNavigation { get; set; }
        public RusViewModel IdWordRusNavigation { get; set; }


        //public static implicit operator EngRusViewModel(TranslationEngRus item)
        //{
        //    return new EngRusViewModel
        //    {
        //        IdTranslation = item.IdTranslation,
        //        IdWordEng = item.IdWordEng,
        //        IdWordRus = item.IdWordRus,
        //        IdCategory = item.IdCategory,
        //        IdPart = item.IdPart,
        //        Example = item.Example,

        //        IdCategoryNavigation = item.IdCategoryNavigation,
        //        IdPartNavigation = item.IdPartNavigation,
        //        IdWordEngNavigation = item.IdWordEngNavigation,
        //        IdWordRusNavigation = item.IdWordRusNavigation

        //    };
        //}

        //public static implicit operator TranslationEngRus(EngRusViewModel item)
        //{
        //    return new TranslationEngRus
        //    {
        //        IdTranslation = item.IdTranslation,
        //        IdWordEng = item.IdWordEng,
        //        IdWordRus = item.IdWordRus,
        //        IdCategory = item.IdCategory,
        //        IdPart = item.IdPart,
        //        Example = item.Example,

        //        IdCategoryNavigation = item.IdCategoryNavigation,
        //        IdPartNavigation = item.IdPartNavigation,
        //        IdWordEngNavigation = item.IdWordEngNavigation,
        //        IdWordRusNavigation = item.IdWordRusNavigation
        //    };
        //}
    }
}
