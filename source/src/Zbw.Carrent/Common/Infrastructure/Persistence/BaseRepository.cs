using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Zbw.Carrent.Common.Domain;

namespace Zbw.Carrent.Common.Infrastructure.Persistence
{
    public abstract class BaseRepository<TEntity, TRequest, TResponse> : IBaseRepository<TEntity, TRequest, TResponse> where TEntity : Entity
    {
        public BaseRepository(CarRentDbContext context)
        {
            _context = context;
        }

        public TResponse Add(TRequest request)
        {
            TEntity entity = RequestConverter()(Guid.NewGuid(), request);

            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            return ResponseConverter()(entity);
        }
        public TResponse Get(Guid id)
        {
            return _context.Set<TEntity>()
                .Where(x => x.Id == id)
                .Select(ResponseConverter())
                .FirstOrDefault()
                ?? throw new Exception();
        }
        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>()
                .Remove(entity);

            _context.SaveChanges();
        }
        public void Remove(Guid id)
        {
            _context.Set<TEntity>()
                .Where(x => x.Id == id)
                .ExecuteDelete();

            _context.SaveChanges();
        }
        public TResponse Update(Guid id, TRequest request)
        {
            var requestConverter = RequestConverter();
            TEntity entity = requestConverter(id, request);

            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();

            var responseConverter = ResponseConverter();
            return responseConverter(entity);
        }

        protected IEnumerable<TResponse> GetAll()
        {
            return _context
                .Set<TEntity>()
                .Select(ResponseConverterSelector())
                .ToList();
        }
        protected IEnumerable<TResponse> GetAll<TProperty1, TProperty2>(Expression<Func<TEntity, TProperty1>> navigationPropertyPath1, Expression<Func<TEntity, TProperty2>> navigationPropertyPath2)
        {
            return _context
                .Set<TEntity>()
                .Include(navigationPropertyPath1)
                .Include(navigationPropertyPath2)
                .Select(ResponseConverterSelector())
                .ToList();
        }

        protected abstract Func<TEntity, TResponse> ResponseConverter();
        protected abstract Func<Guid, TRequest, TEntity> RequestConverter();

        private Expression<Func<TEntity, TResponse>> ResponseConverterSelector()
        {
            var responseConverter = ResponseConverter();
            return x => responseConverter(x);
        }

        protected readonly CarRentDbContext _context;
    }
}
