using BaseEntities.Models;
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


        //public static implicit operator RusEstViewModel(TranslationRusEst item)
        //{
        //    return new RusEstViewModel
        //    {
        //        IdTranslation = item.IdTranslation,
        //        IdWordRus = item.IdWordRus,
        //        IdWordEst = item.IdWordEst,
        //        IdCategory = item.IdCategory,
        //        IdPart = item.IdPart,
        //        Example = item.Example,

        //        IdCategoryNavigation = item.IdCategoryNavigation,
        //        IdPartNavigation = item.IdPartNavigation,
        //        IdWordEstNavigation = item.IdWordEstNavigation,
        //        IdWordRusNavigation = item.IdWordRusNavigation

        //    };
        //}

        //public static implicit operator TranslationRusEst(RusEstViewModel item)
        //{
        //    return new TranslationRusEst
        //    {
        //        IdTranslation = item.IdTranslation,
        //        IdWordRus = item.IdWordRus,
        //        IdWordEst = item.IdWordEst,
        //        IdCategory = item.IdCategory,
        //        IdPart = item.IdPart,
        //        Example = item.Example,

        //        IdCategoryNavigation = item.IdCategoryNavigation,
        //        IdPartNavigation = item.IdPartNavigation,
        //        IdWordEstNavigation = item.IdWordEstNavigation,
        //        IdWordRusNavigation = item.IdWordRusNavigation

        //    };
        //}
    }
}
