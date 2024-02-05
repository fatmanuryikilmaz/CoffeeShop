namespace FikaCoffeeShop.Core
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Basket Basket { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
