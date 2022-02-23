using CoreLayer.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccessLayer.EntityFramework
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(TEntity t)
        {
            using var c = new TContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var c = new TContext())
            {
                return filter == null
                    ? c.Set<TEntity>().ToList()
                    : c.Set<TEntity>().Where(filter).ToList();
            }


        }

        public TEntity GetOne(Expression<Func<TEntity, bool>> filter)
        {
            using (var c = new TContext())
            {
                return c.Set<TEntity>().Where(filter).FirstOrDefault();

            }
        }

        public void Insert(TEntity t)
        {
            using var c = new TContext();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(TEntity t)
        {
            using var c = new TContext();
            c.Update(t);
            c.SaveChanges();

        }
    }
}
