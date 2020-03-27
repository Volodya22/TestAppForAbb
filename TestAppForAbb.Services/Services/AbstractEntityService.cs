using System;
using System.Linq;
using System.Linq.Expressions;
using TestAppForAbb.Core.Models;
using TestAppForAbb.DataLayer.Repository;
using TestAppForAbb.Services.Interfaces;

namespace TestAppForAbb.Services.Services
{
    public class AbstractEntityService<T> : IService<T> where T : AbstractEntity
    {
        private readonly IRepository _context;

        public AbstractEntityService(IRepository context)
        {
            _context = context;
        }

        public int Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return entity.Id;
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);

            if (entity == null)
            {
                return;
            }

            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> Select(Expression<Func<T, bool>> whereClause = null)
        {
            return whereClause == null ? _context.Set<T>().AsQueryable() : _context.Set<T>().Where(whereClause).AsQueryable();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
