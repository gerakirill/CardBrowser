using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CardBrowser.Infrastructure;

namespace CardBrowser.Controllers
{
    public class BaseApiController : ApiController
    {
        private UnitOfWork _unitOfWork;

        public UnitOfWork UnitOfWork => _unitOfWork ?? (_unitOfWork = new UnitOfWork());
    }
}
