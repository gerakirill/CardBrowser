using CardBrowser.Database;

namespace CardBrowser.DAL.Repository
{
    public class CardsAbilitiesValuesRepo: Repository<CardsAbilitiesValues>
    {
        public CardsAbilitiesValuesRepo(DeckGeneralsEntities context) : base(context)
        {
        }
    }
}
