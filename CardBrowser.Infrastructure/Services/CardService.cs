namespace CardBrowser.Infrastructure.Services
{

    #region usings
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using BLL.Models;
    using Database;
    using DAL.Repository;
    using Interfaces;
    using CardTypes = BLL.Enums.CardTypes;
    using ViewModels;
    using Exceptions;
    #endregion

    /// <summary>
    /// Service to work with Card entities
    /// </summary>
    public class CardService : ICardService
    {

        private readonly CardsAbilitiesValuesRepo _cardsAbilitiesValuesRepo;
        private readonly CardRaritiesRepo _cardRaritiesRepo;
        private readonly CardAbilityTypesRepo _cardAbilityTypesRepo;
        private readonly CardsRepo _cardsRepo;
        private readonly CardTypesRepo _cardTypesRepo;

        public CardService(DeckGeneralsEntities context)
        {
            _cardTypesRepo = new CardTypesRepo(context);
            _cardAbilityTypesRepo = new CardAbilityTypesRepo(context);
            _cardRaritiesRepo = new CardRaritiesRepo(context);
            _cardsAbilitiesValuesRepo = new CardsAbilitiesValuesRepo(context);
            _cardsRepo = new CardsRepo(context);
        }

        #region Cards

        /// <summary>
        /// Gets card view model by id
        /// </summary>
        /// <param name="id">Card id</param>
        /// <returns></returns>
        public CardViewModel GetCardViewModel(int id)
        {
            var card = _cardsRepo
                .FindBy(c => c.Id == id);
            return Mapper.Map<Cards, CardViewModel>(card);
        }

        /// <summary>
        /// Gets all CardViewModels
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CardViewModel> GetAllCardsViewModels()
        {
            var cards = _cardsRepo
                .GetAllQueryable();
            return Mapper.Map<IEnumerable<Cards>, IEnumerable<CardViewModel>>(cards);
        }

        /// <summary>
        /// Creates new card
        /// </summary>
        /// <param name="card">Card view model</param>
        public void CreateCard(CardViewModel card)
        {
            if (!string.IsNullOrEmpty(card.Name) && !string.IsNullOrEmpty(card.Image))
            {
                try
                {
                    var newCard = Mapper.Map<CardViewModel, Cards>(card);
                    if (newCard != null)
                    {
                        newCard.Image = Convert.FromBase64String(card.Image);
                        _cardsRepo.Create(newCard);
                    }
                }
                catch (FormatException)
                {
                    throw new InvalidPictureFormatException("Picture has a bad format");
                }
            }
        }

        /// <summary>
        /// Updates card
        /// </summary>
        /// <param name="card">Card view model</param>
        public void UpdateCard(CardViewModel card)
        {
            var cardEntity = _cardsRepo
                .FindBy(c => c.Id == card.Id);
            if (cardEntity != null)
            {
                cardEntity = Mapper.Map<CardViewModel, Cards>(card);
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
                    return Mapper.Map<Cards, CityCard>(card);
                case CardTypes.Resource:
                    return Mapper.Map<Cards, ResourceCard>(card);
                case CardTypes.Scene:
                    return null;
                case CardTypes.Armor:
                    return Mapper.Map<Cards, ArmorCard>(card);
                case CardTypes.Infantry:
                    return null;
                default:
                    return null;
            }
        }
        #endregion

    }
}
