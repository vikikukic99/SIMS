using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Service
{
    public class BaseService<TEntity> where TEntity : class
    {
        protected Repository<TEntity> repository;

        public void Add(Entity entity)
        {
            repository.Add(entity);
        }

        public Entity Get(string id)
        {
            return repository.Get(id);
        }

        public virtual IEnumerable<Entity> GetAll()
        {
            return repository.GetAll();
        }

        public void Remove(Entity entity)
        {
            repository.Remove(entity);
        }

        public virtual IEnumerable<Entity> Search(string term = "")
        {
            return repository.Search();
        }

        public void Save()
        {
            repository.Save();
        }
    }
}