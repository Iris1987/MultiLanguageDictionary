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
    }
}
