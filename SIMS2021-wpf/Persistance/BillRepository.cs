using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Persistance
{
    class BillRepository : Repository<Bill> 
    {
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity entity in ApplicationContext.Instance.Bill)
			{
				if (((Bill)entity).Farmacist.Contains(term) || ((Bill)entity).Time.Contains(term) || ((Bill)entity).ID.Contains(term))
				{
					result.Add(entity);
				}
			}

			return result;
		}
	}
}
