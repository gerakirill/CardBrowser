namespace Infrastructure.Interfaces
{
    public interface IEntityService
    {
        TOut ConvertTo<TIn, TOut>(TIn source);
    }
}
