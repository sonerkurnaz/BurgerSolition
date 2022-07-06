﻿using System.Linq.Expressions;

namespace Burger.BL.Abstract
{
    public interface IManagerBase<T> where T : class, new()
    {
        int Add(T input);
        int Delete(T input);
        int Update(T input);
        T Get(int id);
        IList<T> GetAll(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null
            , params Expression<Func<T, object>>[] include);
    }
}
