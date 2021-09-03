
using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
	public class DoctorRepository : Repository<Doctor>
	{
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity entity in ApplicationContext.Instance.Doctors)
			{
				if (((Doctor)entity).FirstName.Contains(term) || ((Doctor)entity).LastName.Contains(term))
				{
					result.Add(entity);
				}
			}

			return result;
		}
	}
}
