using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Service
{
    public class UserService : BaseService<User>
    {
        public UserService()
        {
            repository = new UserRepository();
        }

        public IEnumerable<Entity> GetAllPatients()
        {
            return ((UserRepository)repository).GetAllPatients();
        }

        public User GetUserWIthUsernameAndPassword(string username, string password)
        {
            return ((UserRepository)repository).GetUserWIthUsernameAndPassword(username, password);
        }
    }
}
