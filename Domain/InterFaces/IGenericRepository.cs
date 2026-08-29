

using System.Linq.Expressions;

namespace Domain.InterFaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetByCondtion(Expression<Func<T, bool>> expression);

    }
}
