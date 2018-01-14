using System.Collections.Generic;
using System.Web.Http;
using CardBrowser.BLL.Models;
using CardBrowser.Models;

namespace CardBrowser.Controllers
{
    
    [RoutePrefix("api/card")]
    public class CardController : BaseApiController
    {
        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult GetAllCards()
        {
            return Ok(UnitOfWork.CardService.GetAllCards());
        }

        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult GetCard([FromUri] int id)
        {
            return Ok(UnitOfWork.CardService.GetCardById(id));
        }
    }
}
