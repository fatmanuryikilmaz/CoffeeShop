using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Core
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public decimal Calorie { get; set; }
        public string? ServingType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
