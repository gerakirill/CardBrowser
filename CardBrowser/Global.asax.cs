namespace CardBrowser
{

    #region usings
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using global::Services;
    using Services;
    #endregion

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            UnityDependencyResolver.RegisterTypes();
            
            // Configures container for WebAPI
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(UnityDependencyResolver.container);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfiguration.Configure();
        }
    }
}
