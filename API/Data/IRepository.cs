using System.Collections.Generic;

namespace API.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void UpdateById(int id, T entity);
        void Remove(T entity);
        void RemoveById(int id);
    }
}