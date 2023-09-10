using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public interface IBaseRepository<in TEntity, in TRequest, out TResponse> where TEntity : Entity
    {
        TResponse Get(Guid id);
        TResponse Add(TRequest request);
        TResponse Update(Guid id, TRequest request);
        void Remove(TEntity entity);
        void Remove(Guid entity);
    }
}