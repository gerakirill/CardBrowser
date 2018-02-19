namespace CardBrowser.Controllers
{
    using System.Collections.Generic;
    #region usings
    using System.Web.Http;
    using System.Web.Http.Description;
    using global::Infrastructure.Interfaces;
    using Models;
    using ViewModels;
    #endregion

    public class CardController : BaseApiController
    {
        
        public CardController(IUnitOfWork UnitOfWork) : base(UnitOfWork)
        {
            
        }

        /// <summary>
        /// Gets all cards
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        [Route("api/cards")]
        [ResponseType(typeof(IEnumerable<CardViewModel>))]
        public IHttpActionResult GetAllCards()
        {
            using (UnitOfWork)
            {
                return Ok(UnitOfWork.CardService.GetAllCardsViewModels());
            }            
        }

        /// <summary>
        /// Gets card by ids
        /// </summary>
        /// <param name="id">Id of card to get</param>
        /// <returns></returns>
        [HttpGet]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        [Route("api/card/{id}")]
        [ResponseType(typeof(CardViewModel))]
        public IHttpActionResult GetCard([FromUri] int id)
        {
            using (UnitOfWork)
            {
                return Ok(UnitOfWork.CardService.GetAllCardsViewModels());
            }                
        }

        /// <summary>
        /// Deletes cards
        /// </summary>
        /// <param name="id">Id of card to delete</param>
        /// <returns></returns>
        [HttpDelete]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        [Route("api/card/delete/{id}")]
        public IHttpActionResult DeleteCard([FromUri] int id)
        {
            using (UnitOfWork)
            {
                UnitOfWork.CardService.DeleteCard(id);
                return Ok();
            }
        }

        /// <summary>
        /// Updates card
        /// </summary>
        /// <param name="card">Card to update</param>
        /// <returns></returns>
        [HttpPut]
        [AllowCrossSiteJson]
        [AllowAnonymous]
        [Route("api/card/update")]
        public IHttpActionResult UpdateCard([FromBody] CardViewModel card)
        {
            using (UnitOfWork)
            {
                UnitOfWork.CardService.UpdateCard(card);
                return Ok();
            }
        }
    }
}
