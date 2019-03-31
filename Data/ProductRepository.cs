using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BestProductFindsApi.Data
{
  public class ProductRepository : IProductRepository
  {
private readonly DataContext _context;
    public ProductRepository(DataContext context)
    {
        this._context = context;
    }

    public async Task<Product[]> GetAllProductsAsync()
    {
      return await _context.Products.ToArrayAsync();
    }

    public async Task<Product[]> GetAllProductsByCategory(int categoryId)
    {
      var query = _context.Products.Include(p => p.Seller).Include(p => p.Category)
      .Where(p => p.Category.Id == categoryId).OrderByDescending(p => p.CreateDate);

      return await query.ToArrayAsync();
    }
  }
}