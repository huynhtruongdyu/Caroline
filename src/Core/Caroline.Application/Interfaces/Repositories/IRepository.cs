using System.Linq.Expressions;

namespace Caroline.Application.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> GetAll(
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            string includeProperties = "");

        TEntity GetById(int id);

        void Insert(TEntity entity);

        void Delete(int entityID);

        void Update(TEntity entity);
    }
}