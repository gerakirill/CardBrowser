namespace Services
{
    #region Usings
    using Infrastructure.Interfaces;
    #endregion

    public class ValueConverter : IEntityService
    {
        public TOut ConvertTo<TIn, TOut>(TIn source)
        {
            return AutoMapper.Mapper.Map<TOut>(source);
        }

        public void AssignTo<TIn, TOut>(TIn source, TOut destination)
        {
            AutoMapper.Mapper.Map<TIn, TOut>(source, destination);
        }
    }
}
