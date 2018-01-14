using CardBrowser.BLL.Enums;

namespace CardBrowser.ViewModels
{
    public class CardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CardTypes CardType { get; set; }
        public CardRarities CardRarity { get; set; }
        public string Image { get; set; }
    }
}
