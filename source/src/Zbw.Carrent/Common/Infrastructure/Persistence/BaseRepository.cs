using Microsoft.EntityFrameworkCore;
using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {

        public BaseRepository(CarRentDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public T Get(Guid id)
        {
            return _context.Set<T>()
                .Where(x => x.Id == id)
                .FirstOrDefault()
                ?? throw new Exception();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public void Remove(T entity)
        {
            _context.Set<T>()
                .Remove(entity);

            _context.SaveChanges();
        }
        public void Remove(Guid id)
        {
            _context.Set<T>()
                .Where(x => x.Id == id)
                .ExecuteDelete();

            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        protected readonly CarRentDbContext _context;
    }
}
