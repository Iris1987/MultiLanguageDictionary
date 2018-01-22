using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class RusViewModel
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
