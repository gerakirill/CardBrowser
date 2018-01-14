using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using CardBrowser.Database;

namespace CardBrowser.DAL
{
    /// <summary>
    /// Generic abstract repository class
    /// Watch only Services deal with it
    /// </summary>
    /// <typeparam name="T">Repository type</typeparam>
    public abstract class Repository<T> where T : class
    {
        private readonly DeckGeneralsEntities _db;

        protected Repository(DeckGeneralsEntities context)
        {
            _db = context;
        }

        /// <summary>
        /// Creates entity type and saes it to DB
        /// </summary>
        /// <param name="item"></param>
        public void Create(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        /// <summary>
        /// Gets Entity type matching bool predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T FindBy(Func<T, bool> predicate)
        {
            return _db.Set<T>()
                .AsNoTracking()
                .FirstOrDefault(predicate);
        }

        /// <summary>
        /// Gets all entity T type
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAllQueryable()
        {
            return _db.Set<T>()
                .AsNoTracking();
        }

        /// <summary>
        /// Gets all entity T type matching bool predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>()
                .AsNoTracking()
                .Where(predicate);
        }
        
        /// <summary>
        /// Removes entity item from DB
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            _db.Set<T>().Remove(item);
            _db.Entry(item).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        /// <summary>
        /// Updates entity T item
        /// </summary>
        /// <param name="item"></param>
        public void Update(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
