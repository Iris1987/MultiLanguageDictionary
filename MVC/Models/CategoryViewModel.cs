using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class CategoryViewModel
    {
       

        public int IdCategory { get; set; }
        public string Categoryname { get; set; }

        public ICollection<SubcategoryViewModel> Subcategory { get; set; }
    }
}
