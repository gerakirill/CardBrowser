namespace Services
{
    #region Usings
    using CardBrowser.BLL;
    using CardBrowser.DAL.Repository;
    using CardBrowser.Infrastructure.Interfaces;
    using Infrastructure.Interfaces;
    using Infrastructure.Repositories;
    using Unity;
    #endregion

    public class UnityDependencyResolver
    {
        public static IUnityContainer container;

        public static void RegisterTypes()
        {
            container = new UnityContainer();

            // Register services
            container.RegisterType<ICardService, CardService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IEntityService, ValueConverter>();

            // Register repositories
            container.RegisterType<ICardsRepository, CardsRepo>();

            //Register database context

        }
    }
}
