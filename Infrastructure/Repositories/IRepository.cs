using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class, new()
    {
        void Create(TEntity item);
        TEntity FindBy(Func<TEntity, bool> predicate);
        IQueryable<TEntity> GetAllQueryable();
        IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
