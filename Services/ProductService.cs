using ProductService.Data;
using ProductService.Models;

namespace ProductService.Services
{
    public interface IProductService
    {
        IEnumerable<Product> SearchProducts(string searchText);
    }
    public class ProductService : IProductService
    {
        private readonly ProductDBContext _context;

        public ProductService(ProductDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> SearchProducts(string searchText)
        {
            return _context.Products.Where(p => p.Tags.Contains(searchText)).ToList();
        }
    }

}