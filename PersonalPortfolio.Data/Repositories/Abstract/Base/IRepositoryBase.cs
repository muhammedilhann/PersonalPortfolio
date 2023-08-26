using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Repositories.Abstract.Base
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> GetAll(bool trackChanges);
        T? GetBy(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
