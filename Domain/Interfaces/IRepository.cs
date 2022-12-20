using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EfCore.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        TEntity Get(Expression<Func<TEntity, bool>> expression);
        TEntity Get(int id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void DeleteById(int id);
        int Count();
    }
}
