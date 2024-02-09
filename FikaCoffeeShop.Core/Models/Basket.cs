namespace FikaCoffeeShop.Core.Models
{
    public class Basket : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
