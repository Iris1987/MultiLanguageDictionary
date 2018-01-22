using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class CategoryViewModel
    {
        public Category()
        {
            Subcategory = new HashSet<Subcategory>();
        }

        public int IdCategory { get; set; }
        public string Categoryname { get; set; }

        public ICollection<Subcategory> Subcategory { get; set; }
    }
}
