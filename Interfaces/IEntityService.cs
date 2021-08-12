using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventLogin.Entities;

namespace EventLogin.Interfaces
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> GetById(Guid id);

        Task<TEntity> Add(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task Delete(Guid id);
    }
}