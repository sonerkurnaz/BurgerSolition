﻿using Burger.DAL.Abstract;
using Burger.DAL.Contexts;
using Burger.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Burger.DAL.Concrete
{
    public class RepositoryBase<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        protected SqlDbContext db;

        public RepositoryBase()
        {
            db = new SqlDbContext();
        }


        public virtual int Add(T input)
        {
            db.Set<T>().Add(input);
            return db.SaveChanges();
        }

        public virtual int Delete(T input)
        {
            db.Set<T>().Remove(input);
            return db.SaveChanges();
        }

        public virtual T Get(int id)
        {
            return db.Set<T>().Find(id);

        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            var query = db.Set<T>().Where(filter);
            return include.Aggregate(query, (current, includeProperty) => current.Include
            (includeProperty));
        }

        public virtual int Update(T input)
        {
            db.Set<T>().Update(input);
            return db.SaveChanges();
        }
    }
}