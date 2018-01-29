namespace CardBrowser.Controllers
{

    #region usings
    using System.Web.Http;
    using Infrastructure;
    using Services;
    #endregion

    public class BaseApiController : ApiController
    {
        private UnitOfWork _unitOfWork;

        public UnitOfWork UnitOfWork => _unitOfWork ?? (_unitOfWork = new UnitOfWork());
    }
}
