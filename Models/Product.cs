using System;
using System.Collections.Generic;

namespace GetThatLook.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
