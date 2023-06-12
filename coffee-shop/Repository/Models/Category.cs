using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
