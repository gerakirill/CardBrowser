namespace CardBrowser.Controllers
{    
    #region usings
    using System.Web.Http;
    using System.Web.Http.Description;
    using global::Infrastructure.Interfaces;
    using Models;
    using ViewModels;
    using ViewModels.BindingModel;
    using System.Collections.Generic;
    #endregion

    public class CardsController : BaseApiController
    {
        
        public CardsController(IUnitOfWork UnitOfWork) : base(UnitOfWork)
        {
            
        }

        /// <summary>
        /// Gets all cards
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        
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
        
        [AllowAnonymous]
        [Route("api/cards/{id}")]
        [ResponseType(typeof(CardViewModel))]
        public IHttpActionResult GetCard([FromUri] int id)
        {
            using (UnitOfWork)
            {
                return Ok(UnitOfWork.CardService.GetCardViewModel(id));
            }                
        }

        /// <summary>
        /// Deletes cards
        /// </summary>
        /// <param name="id">Id of card to delete</param>
        /// <returns></returns>
        [HttpDelete]
        
        [AllowAnonymous]        
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
        [HttpPost]
        
        [AllowAnonymous]
        [Route("api/cards/update")]
        public IHttpActionResult UpdateCard([FromBody] CardBindingModel card)
        {
            using (UnitOfWork)
            {
                UnitOfWork.CardService.UpdateCard(card);
                return Ok();
            }
        }
    }
}
