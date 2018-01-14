using CardBrowser.Database;

namespace CardBrowser.DAL.Repository
{
    public class CardRaritiesRepo : Repository<CardRarities>
    {
        public CardRaritiesRepo(DeckGeneralsEntities context) : base(context)
        {
        }
    }
}
