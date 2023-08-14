using Ardalis.Specification;

namespace Application.Interfaces
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }

    public interface IReadRepositoryAsynk<T> : IReadRepositoryBase<T> where T : class
    {
    }
}
