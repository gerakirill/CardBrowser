namespace CardBrowser.Controllers
{

    #region usings
    using System.Web.Http;
    using Models;
    using ViewModels;
    #endregion

    [RoutePrefix("api/card")]
    public class CardController : BaseApiController
    {
        /// <summary>
        /// Gets all cards
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult GetAllCards()
        {
            return Ok(UnitOfWork.CardService.GetAllCardsViewModels());
        }

        /// <summary>
        /// Gets card by id
        /// </summary>
        /// <param name="id">Id of card to get</param>
        /// <returns></returns>
        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult GetCard([FromUri] int id)
        {
            return Ok(UnitOfWork.CardService.GetCardViewModel(id));
        }

        /// <summary>
        /// Deletes cards
        /// </summary>
        /// <param name="id">Id of card to delete</param>
        /// <returns></returns>
        [HttpDelete]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult DeleteCard([FromUri] int id)
        {
            UnitOfWork.CardService.DeleteCard(id);
            return Ok();
        }

        /// <summary>
        /// Updates card
        /// </summary>
        /// <param name="card">Card to update</param>
        /// <returns></returns>
        [HttpPut]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        public IHttpActionResult UpdateCard([FromBody] CardViewModel card)
        {
            UnitOfWork.CardService.UpdateCard(card);
            return Ok();
        }
    }
}
