using Domain.Common;
using Domain.Products;
using Domain.Products.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IProductRepository : IRepository<Product,ProductId>
    {
        Task<Product> GetBySkuAsync(Sku sku);

    }
}
