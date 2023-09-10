namespace Zbw.Carrent.Common.Domain
{
    public interface IBaseRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(Guid entity);
    }
}
