namespace CardBrowser.BLL
{
    #region usings
    using System;
    using Database;
    using global::Infrastructure.Interfaces;
    using Unity;
    using Infrastructure.Interfaces;
    #endregion


    /// <summary>
    /// Incapsulates data aceess layer work
    /// Gives the same DB context
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {

        #region Fields
        private readonly DeckGeneralsEntities _db;
        //private ICardService _cardService;
        //private readonly IUnityContainer container = new Uni();
        #endregion

        #region Properties
        public ICardService CardService { get; set; }
        #endregion

        public UnitOfWork(ICardService cardService)
        {
            CardService = cardService;
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
