using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
	public class PatientRepository : Repository<Patient>
	{
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity entity in ApplicationContext.Instance.Patients)
			{
				if (((Patient)entity).FirstName.Contains(term) || ((Patient)entity).LastName.Contains(term))
				{
					result.Add(entity);
				}
			}

			return result;
		}
	}
}
