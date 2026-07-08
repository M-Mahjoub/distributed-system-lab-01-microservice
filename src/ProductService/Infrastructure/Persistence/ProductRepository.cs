using Application.Abstractions.Repositories;
using Domain.Products;
using Domain.Products.ValueObjects;

namespace Infrastructure.Persistence
{
    public class ProductRepository : BaseRepository<Product,ProductId>, IProductRepository
    {
        public Task<Product> GetBySkuAsync(Sku sku)
        {
            throw new NotImplementedException();
        }
    }
}
