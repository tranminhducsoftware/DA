using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace DoAn.Data
{
    public class Reponsitory<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _dbContext;
        private DbSet<T> _entities;

        public Reponsitory(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<T>();
        }

        public async Task<List<T>> Get()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> Get(int id)
        {
            return await _entities.FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task<T> Create(T entity)
        {
            _entities.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        } 

        public async Task Update(T entityToUpdate)
        {
            _entities.Update(entityToUpdate);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<bool> Remove(int id)
        {
            try
            {
                var entity = await Get(id);
                _entities.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
