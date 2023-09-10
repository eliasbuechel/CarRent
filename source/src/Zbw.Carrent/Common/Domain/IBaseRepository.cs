using System.Linq.Expressions;

namespace Zbw.Carrent.Common.Domain
{
    public interface IBaseRepository<TEntity, TRequest, TResponse> where TEntity : Entity
    {
        TResponse Get(Guid id);
        TResponse Add(TRequest request);
        TResponse Update(Guid id, TRequest request);
        void Remove(TEntity entity);
        void Remove(Guid entity);
    }
}
