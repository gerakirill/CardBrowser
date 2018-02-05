namespace CardBrowser.Services
{

    #region usings
    using System.Web.Mvc;
    using Infrastructure.Interfaces;
    using Unity;
    using Unity.Mvc5;
    #endregion

    public class UnityDependency
    {
        public static void Start()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<ICardService, CardService>();
            return container;
        }
    }
}
