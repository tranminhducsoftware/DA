using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Models.Context;

namespace DoAn.Data
{
    public interface IRepository<T> where T :BaseEntity
    {
        Task<List<T>> Get();

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task Update(T entityToUpdate);

        Task<bool> Remove(int id);
    }
}
