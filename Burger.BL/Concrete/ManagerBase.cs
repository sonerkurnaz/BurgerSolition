using Burger.BL.Abstract;
using Burger.DAL.Abstract;
using Burger.DAL.Concrete;
using Burger.Entities;
using System.Linq.Expressions;

namespace Burger.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : BaseEntity, new()
    {
        protected IBaseRepository<T> repository;
        public ManagerBase()
        {
            repository = new RepositoryBase<T>();
        }
        public virtual int Add(T input)
        {
            throw new NotImplementedException();
        }

        public virtual int Delete(T input)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            throw new NotImplementedException();
        }

        public virtual int Update(T input)
        {
            throw new NotImplementedException();
        }
    }
}

