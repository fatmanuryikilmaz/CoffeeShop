namespace FikaCoffeeShop.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public string Image { get; set; }
        //public ICollection<Category> Categories { get; set; }
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
