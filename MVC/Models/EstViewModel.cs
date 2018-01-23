using BaseEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class EstViewModel
    {
       

        public int IdWord { get; set; }
        public string Word { get; set; }

        public ICollection<EngEstViewModel> TranslationEngEst { get; set; }
        public ICollection<RusEstViewModel> TranslationRusEst { get; set; }

        public static implicit operator EstViewModel(LangEstonian item)
        {
            return new EstViewModel
            {
                IdWord = item.IdWord,
                Word = item.Word

            };
        }

        public static implicit operator LangEstonian(EstViewModel item)
        {
            return new LangEstonian
            {
                IdWord = item.IdWord,
                Word = item.Word

            };
        }
    }
}
