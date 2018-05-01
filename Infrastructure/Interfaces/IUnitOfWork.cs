namespace Infrastructure.Interfaces
{
    #region Usings
    using System;
    using CardBrowser.Infrastructure.Interfaces;
    #endregion

    public interface IUnitOfWork : IDisposable
    {
        ICardService CardService { get; }
                
    }
}
