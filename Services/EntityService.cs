using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventLogin.Database;
using EventLogin.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventLogin.Services
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext ApplicationDbContext;
        // Konstruktor
        public EntityService(ApplicationDbContext applicationDbContext)
        {
            this.ApplicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await this.ApplicationDbContext.Set<TEntity>().ToArrayAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await this.ApplicationDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            var entityAdd = await this.ApplicationDbContext.Set<TEntity>().AddAsync(entity);
            await this.ApplicationDbContext.SaveChangesAsync();
            return entityAdd.Entity;

        }

        public async Task<TEntity> Update(TEntity entity)
        {
            var entityUpdate =  this.ApplicationDbContext.Set<TEntity>().Update(entity);
            await this.ApplicationDbContext.SaveChangesAsync();
            return entityUpdate.Entity;
        }

        public async Task Delete(Guid id)
        {
            this.ApplicationDbContext.Set<TEntity>().Remove(await GetById(id));
            await this.ApplicationDbContext.SaveChangesAsync();
        }
    }
}