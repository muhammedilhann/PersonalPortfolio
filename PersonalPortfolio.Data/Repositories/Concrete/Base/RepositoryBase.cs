using Microsoft.EntityFrameworkCore;
using PersonalPortfolio.Data.Context;
using PersonalPortfolio.Data.Repositories.Abstract.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Concrete.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _context;
        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }
        public void Create(T entitiy)
        {
            _context.Set<T>().Add(entitiy);
        }

        public void Delete(T entitiy)
        {
            _context.Set<T>().Remove(entitiy);
        }

        public IQueryable<T> GetAll(bool trackChanges)
        {
            return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
        }

        public T? GetBy(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges
              ? _context.Set<T>().Where(expression).SingleOrDefault()
              : _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefault();
        }

        public void Update(T entitiy)
        {
            _context.Set<T>().Update(entitiy);
        }
    }
}
