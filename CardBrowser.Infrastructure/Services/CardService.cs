using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CardBrowser.BLL.Models;
using CardBrowser.Database;
using CardBrowser.DAL.Repository;
using CardBrowser.Infrastructure.Interfaces;
using CardTypes = CardBrowser.BLL.Enums.CardTypes;

namespace CardBrowser.Infrastructure.Services
{
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

        #region Card types



        #endregion

        #region Cards

        public CardBase GetCardById(int id)
        {
            return MapToCardBase(_cardsRepo
                .FindBy(c => c.Id == id));
        }

        
        public IEnumerable<CardBase> GetAllCards()
        {
            var cards = _cardsRepo
                .GetAllQueryable();
            var list = new List<CardBase>();
            foreach (var card in cards)
            {
                list.Add(MapToCardBase(card));
            }
            return list;
        }

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

        public void CreateCard(CardBase card)
        {
            throw new NotImplementedException();
        }

        public void UpdateCard(CardBase card)
        {
            throw new NotImplementedException();
        }

        public void DeleteCard(CardBase card)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
