using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }

        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
