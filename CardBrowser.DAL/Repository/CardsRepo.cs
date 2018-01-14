using CardBrowser.Database;

namespace CardBrowser.DAL.Repository
{
    public class CardsRepo : Repository<Cards>
    {
        public CardsRepo(DeckGeneralsEntities context) : base(context)
        {
        }
    }
}
