using SIMS2021.Core;
using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Add(Entity entity)
        {
            ApplicationContext.Instance.Get(typeof(TEntity)).Add(entity);
        }

        public Entity Get(string id)
        {
            return ApplicationContext.Instance.Get(typeof(TEntity)).Where(x => x.ID == id).FirstOrDefault();
        }

        public virtual IEnumerable<Entity> GetAll()
        {
            return ApplicationContext.Instance.Get(typeof(TEntity));
        }

        public void Remove(Entity entity)
        {
            Entity entityToRemove = Get(entity.ID);

            ApplicationContext.Instance.Get(typeof(TEntity)).Remove(entityToRemove);
        }

        public virtual IEnumerable<Entity> Search(string term = "")
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            ApplicationContext.Instance.Save();
        }
    }
}
