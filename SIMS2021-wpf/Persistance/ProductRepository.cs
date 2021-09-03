using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
	public class ProductRepository : Repository<Products>
	{
		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity product in ApplicationContext.Instance.Products)
			{
				if (((Products)product).Name.Contains(term) || ((Products)product).Description.Contains(term))
				{
					result.Add(product);
				}
			}

			return result;
        }
	}
}
