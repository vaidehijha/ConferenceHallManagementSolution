using DAL_ConferenceHallManagement.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_ConferenceHallManagement
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAysnc();
        Task<TEntity?> GetByIdAysnc(int id);
        void Add(TEntity entity);
        Task DeleteAsync(int id);
        void Update(TEntity entity);
        ConferenceHallManagementContext GetContext();
    }
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ConferenceHallManagementContext _context;

        public Repository(ConferenceHallManagementContext context)
        {
            _context = context;
        }
        
        public ConferenceHallManagementContext GetContext()
        {
            return _context;
        }
        
        public virtual void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAysnc()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAysnc(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
        }
    }
}
