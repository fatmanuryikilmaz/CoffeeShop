using FikaCoffeeShop.Core.Models;
using FikaCoffeeShop.Core.Repositories;
using Microsoft.EntityFrameworkCore;
namespace FikaCoffeeShop.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
           return await  _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
