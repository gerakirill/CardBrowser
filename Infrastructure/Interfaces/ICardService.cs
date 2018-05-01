namespace CardBrowser.Infrastructure.Interfaces
{
    #region usings
    using System.Collections.Generic;
    using ViewModels;
    using ViewModels.BindingModel;
    #endregion

    public interface ICardService
    {
        CardViewModel GetCardViewModel(int id);
        IEnumerable<CardViewModel> GetAllCardsViewModels();
        void CreateCard(CardBindingModel card);
        void UpdateCard(CardBindingModel card);
        void DeleteCard(int cardId);        
    }
}
