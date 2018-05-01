namespace CardBrowser.ViewModels
{    
    public class CardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardTypeId { get; set; }
        public int CardRarityId { get; set; }
        public string Image { get; set; }
        public int? ResourceRequirement { get; set; }
        public string CardText { get; set; }
        public int? AttackValue { get; set; }
        public int? StrengthValue { get; set; }
    }
}
