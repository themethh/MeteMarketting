using MeteMarketting.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace MeteMarketting.Core.Data.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var eklendiEntity = context.Entry(entity);
                eklendiEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var guncellendiEntity = context.Entry(entity);
                guncellendiEntity.State = EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var silindiEntity = context.Entry(entity);
                silindiEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
