using Microsoft.EntityFrameworkCore;
using SMP.Core.Interfaces;
using SMP.EF.Data;
using System.Linq.Expressions;

namespace SMP.EF.Repositories
{
    public class DataHelper<T> : IDataHelper<T> where T : class
    {
        private AppDbContext context;
        public DataHelper() {
            context = new AppDbContext();
        }
        public DataHelper(AppDbContext _context)
        {
            context = _context;
        }
        #region Main Methods
        public async Task<T> AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            return entity;
        }
        public async Task<IEnumerable<T>> AddBulkAsync(IEnumerable<T> entity)
        {
            await context.Set<T>().AddRangeAsync(entity);
            return entity;
        }

        public async Task<T> DeleteAsync(int id)
        {
            var existingEntity = await context.Set<T>().FindAsync(id);
            if (existingEntity != null)
            {
                context.Entry(existingEntity).State = EntityState.Deleted;
                return existingEntity;

            }
            return null;
        }

        public async Task<T> EditAsync(int id, T entity)
        {
            var existingEntity = await context.Set<T>().FindAsync(id);

            if (existingEntity != null)
                context.Entry(existingEntity).CurrentValues.SetValues(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = context.Set<T>();
            await Task.Run(()=> IncludeData(query, includes));

            return query.Where(match).ToList();
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        #endregion


        #region Helper Methods
        private void IncludeData(IQueryable<T> query, string[] includes)
        {
            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);
        }
        #endregion
    }
}
