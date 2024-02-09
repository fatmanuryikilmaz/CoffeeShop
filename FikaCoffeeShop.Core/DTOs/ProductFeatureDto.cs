using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Core.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public int Calorie { get; set; }
        public string ServingType { get; set; }
        public int ProductId { get; set; }
    }
}
