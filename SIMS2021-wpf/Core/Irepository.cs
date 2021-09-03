using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Entity Get(string id);

        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> Search(string term = "");

        void Add(Entity entity);
        void Remove(Entity entity);
    }
}
