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
        #endregion

        #region Properties
        public ICardService CardService { get; set; }
        #endregion

        public UnitOfWork(ICardService cardService)
        {
            CardService = cardService;            
        }

        #region Utils
        ~UnitOfWork()
        {
            Dispose();
        }

        private bool disposed = false;

        public void Dispose()
        {           
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
