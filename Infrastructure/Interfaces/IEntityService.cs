namespace Infrastructure.Interfaces
{
    public interface IEntityService
    {
        TOut ConvertTo<TIn, TOut>(TIn source);
        void AssignTo<TIn, TOut>(TIn source, TOut destination);
    }
}
