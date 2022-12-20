using DomainLayer.Entities;
using DomainLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EfCore.Repositories
{
    public class ProductRepository : Repository<ProductEntity>, IProductRepository
    {
        public ProductRepository(PersistenceDbContext context) : base(context)
        {
        }

        public List<ProductEntity> GetProductwithCategory()
        {
            return context.Products.Include(p => p.Category).ToList();
        }
    }
}
