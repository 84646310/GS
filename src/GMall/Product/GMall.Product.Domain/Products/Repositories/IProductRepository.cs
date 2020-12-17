using GMall.Types;
using GS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMall.Product.Domain.Products.Repositories
{
    public interface IProductRepository : IRepository<Product, ProductId>
    {
    }
}
