using System;
using CardBrowser.Database;
using CardBrowser.Infrastructure.Interfaces;
using CardBrowser.Infrastructure.Services;

namespace CardBrowser.Infrastructure
{
    /// <summary>
    /// Incapsulates data aceess layer work
    /// Gives the same DB context
    /// </summary>
    public class UnitOfWork
    {
        #region Fields
        private readonly DeckGeneralsEntities _db;
        private ICardService _cardService;
        #endregion

        #region Properties
        public ICardService CardService => _cardService ?? (_cardService = new CardService(_db));
        #endregion
        public UnitOfWork()
        {
            _db = new DeckGeneralsEntities();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        #region Utils
        ~UnitOfWork()
        {
            Dispose(false);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
