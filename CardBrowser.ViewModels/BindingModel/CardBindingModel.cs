namespace CardBrowser.ViewModels.BindingModel
{
    public class CardBindingModel
    {
        /// <summary>
        /// Id of card
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Strength value of card
        /// </summary>
        public int? StrengthValue { get; set; }

        /// <summary>
        /// Attack value of card
        /// </summary>
        public int? AttackValue { get; set; }

        /// <summary>
        /// Card Resource Requirement
        /// </summary>
        public int? ResourceRequirement { get; set; }
    }
}
