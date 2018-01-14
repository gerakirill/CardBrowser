using System.Drawing;

using CardBrowser.BLL.Enums;



namespace CardBrowser.BLL.Models
{
    public abstract class CardBase
    {
        protected CardBase()
        {
            
        }

        protected CardBase(int cardId, string name, CardTypes cardType, CardRarities cardRarity)
        {
            Id = cardId;
            Name = name;
            CardType = cardType;
            CardRarity = cardRarity;
        }

        public int Id { get; private set; }
        public string Name{ get; private set; }
        public CardTypes CardType { get; private set; }
        public CardRarities CardRarity{ get; private set; }
        public byte[] Image{ get; set; }
    }
}
