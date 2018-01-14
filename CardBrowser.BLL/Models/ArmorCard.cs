using System.Collections.Generic;
using CardBrowser.BLL.Enums;

namespace CardBrowser.BLL.Models
{
    public class ArmorCard : UnitCard
    {
        public ArmorCard()
        {
            
        }
        public ArmorCard(int cardId, string name, CardTypes cardType, CardRarities cardRarity, IEnumerable<Ability> abilities) : base(cardId, name, cardType, cardRarity, abilities)
        {
        }
    }
}
