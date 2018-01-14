using CardBrowser.Database;

namespace CardBrowser.DAL.Repository
{
    public class CardAbilityTypesRepo : Repository<CardAbilityTypes>
    {
        public CardAbilityTypesRepo(DeckGeneralsEntities context) : base(context)
        {
        }
    }
}
