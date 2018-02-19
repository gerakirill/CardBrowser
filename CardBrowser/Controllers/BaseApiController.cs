namespace CardBrowser.Controllers
{

    #region usings
    using System.Web.Http;
    using BLL;
    using global::Infrastructure.Interfaces;
    using Infrastructure;
    using Infrastructure.Interfaces;
    using Services;
    #endregion

    public class BaseApiController : ApiController
    {
        protected IUnitOfWork UnitOfWork;

        public BaseApiController(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
    }
}
