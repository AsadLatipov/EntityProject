using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityProject.Data.Contexts;
using EntityProject.Data.IRepository;

namespace EntityProject.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DatabaseContext _context = new DatabaseContext();
        protected DbSet<T> _dbset;
        public GenericRepository()
        {
            _dbset = _context.Set<T>();
        }
        public async Task<T> CreateAsycn(T entity)
        {
            var res = await _dbset.AddAsync(entity);
            return res.Entity;
        }

        public async Task<T> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var result = await _dbset.Where(expression).FirstOrDefaultAsync();
            var res = _dbset.Remove(result);
            await _context.SaveChangesAsync();
            return res.Entity;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
            return expression == null ? _dbset : _dbset.Where(expression);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbset.Where(expression).FirstOrDefaultAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var res = _dbset.Update(entity);
            await _context.SaveChangesAsync();
            return res.Entity;
        }
    }
}
