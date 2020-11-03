using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace API.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;

        public Repository(DataContext context) => this.context = context;

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
            this.context.SaveChanges();
        }

        public IEnumerable<T> GetAll() => this.context.Set<T>().AsEnumerable<T>();

        public T GetById(int id) => this.context.Set<T>().Find(id);

        public void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
            this.context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
            this.context.SaveChanges();
        }

        public void RemoveById(int id)
        {
            T aux = this.context.Set<T>().Find(id);
            this.context.Set<T>().Remove(aux);
            this.context.SaveChanges();
        }

        public void UpdateById(int id, T entity){
            entity.Id = id;
            this.context.Set<T>().Update(entity);
            this.context.SaveChanges();
        }

    }
}