namespace Infrastructure
{
    #region Usings
    using Interfaces;
    #endregion

    public abstract class BaseService
    {
        protected IEntityService entityService;

        public BaseService(IEntityService entityService)
        {
            this.entityService = entityService;
        }
    }
}
