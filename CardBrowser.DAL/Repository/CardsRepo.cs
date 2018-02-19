namespace CardBrowser.DAL.Repository
{
    using System;
    #region Usings
    using CardBrowser.Database;
    using global::Infrastructure.Repositories;
    #endregion

    public class CardsRepo : Repository<Cards>, ICardsRepository
    {
        public CardsRepo(DeckGeneralsEntities context) : base(context)
        {
        }

        public void Dispose()
        {
            
        }
    }
}
