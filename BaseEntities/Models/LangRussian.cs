using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class LangRussian
    {
        public LangRussian()
        {
            TranslationEngRus = new HashSet<TranslationEngRus>();
            TranslationRusEst = new HashSet<TranslationRusEst>();
        }

        public int IdWord { get; set; }
        public string Word { get; set; }

        public ICollection<TranslationEngRus> TranslationEngRus { get; set; }
        public ICollection<TranslationRusEst> TranslationRusEst { get; set; }
    }
}
