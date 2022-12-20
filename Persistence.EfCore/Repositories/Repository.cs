using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EfCore.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly PersistenceDbContext context;

        public Repository(PersistenceDbContext context)
        {
            this.context = context;
        }
        public TEntity Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public int Count()
        {
            return context.Set<TEntity>().Count();
        }

        public void DeleteById(int id)
        {
            var entity = context.Set<TEntity>().Find(id);
            if (entity == null)
                return;
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return context.Set<TEntity>().FirstOrDefault(expression);
        }
        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return context.Set<TEntity>().Where(expression).ToList();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
