﻿namespace CardBrowser.ViewModels
{

    #region usings
    using CardBrowser.BLL.Enums;
    #endregion

    public class CardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardType { get; set; }
        public int CardRarity { get; set; }
        public string Image { get; set; }
        public int? ResourceRequirement { get; set; }
        public string CardText { get; set; }
        public int? AttackValue { get; set; }
        public int? StrengthValue { get; set; }
    }
}
