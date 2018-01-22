using System;
using System.Collections.Generic;

namespace BaseEntities.Models
{
    public partial class Category
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
