using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Service
{
    public class IngredientService : BaseService<Ingredient>
    {
        public IngredientService()
        {
            repository = new IngredientRepository();
        }

		public IEnumerable<Entity> SortByQUantity()
		{
			return ((IngredientRepository)repository).SortByQUantity();
		}


		public int MedicamentCount(Ingredient ingredient)
		{
			return ((IngredientRepository)repository).MedicamentCount(ingredient);
		}

		public IEnumerable<Entity> Sort()
		{
			return ((IngredientRepository)repository).Sort();
		}

	}


}
