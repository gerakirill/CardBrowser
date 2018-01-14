using System.Web.Mvc;
using CardBrowser.Infrastructure.Interfaces;
using CardBrowser.Infrastructure.Services;
using Unity;
using Unity.Mvc5;

namespace CardBrowser.Infrastructure
{
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
