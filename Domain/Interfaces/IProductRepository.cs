using DomainLayer.Entities;
using Persistence.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Interfaces
{
    public interface IProductRepository: IRepository<ProductEntity>
    {
        List<ProductEntity> GetProductwithCategory();
    }
}
