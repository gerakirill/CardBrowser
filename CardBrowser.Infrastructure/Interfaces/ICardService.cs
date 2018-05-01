namespace CardBrowser.Infrastructure.Interfaces
{

    #region usings
    using System.Collections.Generic;
    using ViewModels;
    #endregion

    public interface ICardService
    {
        CardViewModel GetCardViewModel(int id);
        IEnumerable<CardViewModel> GetAllCardsViewModels();
        void CreateCard(CardViewModel card);
        void UpdateCard(CardViewModel card);
        void DeleteCard(int cardId);        
    }
}
