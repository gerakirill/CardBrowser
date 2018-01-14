using CardBrowser.Database;

namespace CardBrowser.DAL.Repository
{
    public class CardTypesRepo: Repository<CardTypes>
    {
        public CardTypesRepo(DeckGeneralsEntities context) : base(context)
        {
        }
    }
}
