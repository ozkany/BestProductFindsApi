using System.Threading.Tasks;

namespace BestProductFindsApi.Data
{
    public interface IProductRepository
    {
      Task<Product[]> GetAllProductsAsync();
      Task<Product[]> GetAllProductsByCategory(int categoryId);
    }
}