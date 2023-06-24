using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class Item
    {
        public Item()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int TypeId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public bool Status { get; set; }

        public virtual Category Type { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
