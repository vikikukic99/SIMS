using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SIMS2021.Persistance
{
    public class UserRepository : Repository<User>
    {
        public override IEnumerable<Entity> Search(string term = "")
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity user in ApplicationContext.Instance.Users)
            {
                if (((User)user).Name.Contains(term) || ((User)user).Email.Contains(term) || ((User)user).Surname.Contains(term))
                {
                    result.Add(user);
                }
            }

            return result;
        }

        public IEnumerable<Entity> GetAllPatients()
        {
            List<Entity> result = new List<Entity>();

            foreach (Entity user in ApplicationContext.Instance.Users)
            {
                if (((User)user).UserType == SIMS2021_wpf.CompositeComon.Enums.UserType.Patient)
                {
                    result.Add(user);
                }
            }

            return result;
        }

        public User GetUserWIthUsernameAndPassword(string username, string password) 
        {
            foreach (User user in ApplicationContext.Instance.Users) 
            {
                if (user.Email == username && user.Password == password) 
                {
                    return user;
                }
            }

            return null;
        }

    }
}
