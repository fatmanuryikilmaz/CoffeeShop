namespace FikaCoffeeShop.Core
{
    public class Order : BaseEntity
    {
        public int userId { get; set; }
        public User User { get; set;}
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
