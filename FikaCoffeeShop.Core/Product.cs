using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Core
{
    public class Product:BaseEntity
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        //public ICollection<Category> Categories { get; set; }
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
