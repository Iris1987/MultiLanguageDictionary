﻿using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class Subcategory
    {
        public Subcategory()
        {
            TranslationEngEst = new HashSet<TranslationEngEst>();
            TranslationEngRus = new HashSet<TranslationEngRus>();
            TranslationRusEst = new HashSet<TranslationRusEst>();
        }

        public int IdSubcategory { get; set; }
        public string Subcategoryname { get; set; }
        public int IdCategory { get; set; }

        public Category IdCategoryNavigation { get; set; }
        public ICollection<TranslationEngEst> TranslationEngEst { get; set; }
        public ICollection<TranslationEngRus> TranslationEngRus { get; set; }
        public ICollection<TranslationRusEst> TranslationRusEst { get; set; }
    }
}
