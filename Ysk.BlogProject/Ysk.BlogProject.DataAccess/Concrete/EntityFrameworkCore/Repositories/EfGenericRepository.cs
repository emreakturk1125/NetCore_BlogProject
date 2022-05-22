using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks; 
using Ysk.BlogProject.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Ysk.BlogProject.DataAccess.Abstract;
using Ysk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Context;

namespace Ysk.BlogProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class, ITable, new()
    {
        public async Task AddAsync(T entity)
        {
            using var context = new BlogProjectContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            using var context = new BlogProjectContext();
            return await context.FindAsync<T>(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            using var context = new BlogProjectContext();

            return await context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            using var context = new BlogProjectContext();
            return await context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> keySelector)
        {
            using var context = new BlogProjectContext();
            return await context.Set<T>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            using var context = new BlogProjectContext();
            return await context.Set<T>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            using var context = new BlogProjectContext();
            return await context.Set<T>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(T entity)
        {
            using var context = new BlogProjectContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            using var context = new BlogProjectContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
