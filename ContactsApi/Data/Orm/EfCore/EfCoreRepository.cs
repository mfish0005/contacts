using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Data.Orm.EfCore
{
    public abstract class EfCoreRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity 
        where TContext : DbContext
    {
        private readonly TContext _context;
        
        protected EfCoreRepository(TContext context)
        {
            this._context = context;
        }
        
        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            
            await _context.SaveChangesAsync();
            
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            
            if (entity == null)
            {
                return null;
            }

            _context.Set<TEntity>().Remove(entity);
            
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<int> GetCount()
        {
            return await _context.Set<TEntity>().CountAsync();
        }
        
        public async Task<PagedList<TEntity>> GetPagedList(int pageNumber, int pageSize)
        {
            return await PagedList<TEntity>.ToPagedList(
                _context.Set<TEntity>().OrderBy(e => e.Id),
                pageNumber,
                pageSize);
        }
        
        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();
            
            return entity;
        }

    }
}