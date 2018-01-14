using System.Collections.Generic;
using CardBrowser.BLL.Enums;

namespace CardBrowser.BLL.Models
{
    public class CityCard: CardBase
    {
        public IEnumerable<Ability> Abilities { get; private set; }

        public CityCard()
        {

        }

        public CityCard(int cardId, string name, CardTypes cardType, CardRarities cardRarity, IEnumerable<Ability> abilities) : base(cardId, name, cardType, cardRarity)
        {
            Abilities = abilities;
        }

    }
}
