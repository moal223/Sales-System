using System.Linq.Expressions;

namespace SMP.Core.Interfaces
{
    public interface IDataHelper<T> where T : class
    {
        // Write
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddBulkAsync(IEnumerable<T> entity);
        Task<T> EditAsync(int id, T entity);
        Task<T> DeleteAsync(int id);
        // Read
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> match, string[] includes = null);
        IEnumerable<T> GetAll(); 
    }
}
