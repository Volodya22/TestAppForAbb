using System;
using System.Linq;
using System.Linq.Expressions;
using TestAppForAbb.Core.Interfaces;

namespace TestAppForAbb.Services.Interfaces
{
    public interface IService<T> where T : IAbstractEntity
    {
        IQueryable<T> Select(Expression<Func<T, bool>> whereClause = null);

        T GetById(int id);

        int Create(T entity);

        void Update(T entity);

        void Delete(int id);
    }
}
