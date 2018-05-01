namespace CardBrowser.BLL
{
    #region usings
    using System;
    using System.Collections.Generic;
    using Database;
    using DAL.Repository;
    using CardTypes = Enums.CardTypes;
    using Infrastructure.Interfaces;
    using Models;
    using ViewModels;
    using global::Infrastructure;
    using global::Infrastructure.Interfaces;
    using Exceptions;
    using global::Infrastructure.Repositories;
    using ViewModels.BindingModel;
    #endregion

    /// <summary>
    /// Service to work with Card entities
    /// </summary>
    public class CardService : BaseService, ICardService
    {        
        
        private readonly ICardsRepository _cardsRepo;
        
        public CardService(IEntityService entityService, ICardsRepository cardsRepo) : base(entityService)
        {           
            _cardsRepo = cardsRepo;
        }


        /// <summary>
        /// Gets card view model by id
        /// </summary>
        /// <param name="id">Card id</param>
        /// <returns></returns>
        public CardViewModel GetCardViewModel(int id)
        {
            var card = _cardsRepo
                .FindBy(c => c.Id == id);
            return this.entityService.ConvertTo<Cards, CardViewModel>(card);
        }

        /// <summary>
        /// Gets all CardViewModels
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CardViewModel> GetAllCardsViewModels()
        {
            var cards = _cardsRepo
                .GetAllQueryable();
            return this.entityService.ConvertTo<IEnumerable<Cards>, IEnumerable<CardViewModel>>(cards);
        }

        /// <summary>
        /// Creates new card
        /// </summary>
        /// <param name="card">Card view model</param>
        public void CreateCard(CardBindingModel cardModel)
        {
            //if (!string.IsNullOrEmpty(cardModel.Name) && !string.IsNullOrEmpty(card.Image))
            //{
            //    try
            //    {
            //        Cards newCard = new Cards();
            //        newCard = this.entityService.ConvertTo<CardBindingModel, Cards>(cardModel);
            //        if (newCard != null)
            //        {
            //            newCard.Image = Convert.FromBase64String(card.Image);
            //            _cardsRepo.Create(newCard);
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        throw new InvalidPictureFormatException("Picture has a bad format");
            //    }
            //}
        }

        /// <summary>
        /// Updates card
        /// </summary>
        /// <param name="card">Card view model</param>
        public void UpdateCard(CardBindingModel card)
        {
            var cardEntity = _cardsRepo
                .FindBy(c => c.Id == card.Id);
            if (cardEntity != null)
            {
                var updatedCard = this.entityService.ConvertTo<CardBindingModel, Cards>(card);
                this.entityService.AssignTo<Cards, Cards>(updatedCard, cardEntity);
                _cardsRepo.Update(cardEntity);
            }
        }

        /// <summary>
        /// Deletes card
        /// </summary>
        /// <param name="cardId">Card id</param>
        public void DeleteCard(int cardId)
        {
            var cardEntity = _cardsRepo
               .FindBy(c => c.Id == cardId);
            if (cardEntity != null)
            {
                _cardsRepo.Remove(cardEntity);
            }
        }

        /// <summary>
        /// Maps card entity to its type
        /// </summary>
        /// <param name="card">Card entity</param>
        /// <returns></returns>
        private CardBase MapToCardBase(Cards card)
        {
            switch ((CardTypes)card.CardTypeId)
            {
                case CardTypes.City:
                    return this.entityService.ConvertTo<Cards, CityCard>(card);
                case CardTypes.Resource:
                    return this.entityService.ConvertTo<Cards, ResourceCard>(card);
                case CardTypes.Scene:
                    return null;
                case CardTypes.Armor:
                    return this.entityService.ConvertTo<Cards, ArmorCard>(card);
                case CardTypes.Infantry:
                    return null;
                default:
                    return null;
            }
        }     

    }
}
