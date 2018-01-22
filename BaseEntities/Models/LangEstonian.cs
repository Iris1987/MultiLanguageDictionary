using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class LangEstonian
    {
        public LangEstonian()
        {
            TranslationEngEst = new HashSet<TranslationEngEst>();
            TranslationRusEst = new HashSet<TranslationRusEst>();
        }

        public int IdWord { get; set; }
        public string Word { get; set; }

        public ICollection<TranslationEngEst> TranslationEngEst { get; set; }
        public ICollection<TranslationRusEst> TranslationRusEst { get; set; }
    }
}
