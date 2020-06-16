using System;
using System.Collections.Generic;

namespace GetThatLook.Models
{
    public partial class Cart
    {
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Username { get; set; }

        public virtual Product Product { get; set; }
    }
}
