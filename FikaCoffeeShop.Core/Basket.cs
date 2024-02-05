namespace FikaCoffeeShop.Core
{
    public class Basket : BaseEntity
    {
        public int userId { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
