using Domain.Aggregates.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
