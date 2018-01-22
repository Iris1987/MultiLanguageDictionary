using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class LangEnglish
    {
        public LangEnglish()
        {
            TranslationEngEst = new HashSet<TranslationEngEst>();
            TranslationEngRus = new HashSet<TranslationEngRus>();
        }

        public int IdWord { get; set; }
        public string Word { get; set; }

        public ICollection<TranslationEngEst> TranslationEngEst { get; set; }
        public ICollection<TranslationEngRus> TranslationEngRus { get; set; }
    }
}
