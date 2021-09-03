using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
    public class IngredientRepository : Repository<Ingredient>
    {
        public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();
			MedicamentRepository medicamentRepository = new MedicamentRepository(); 

			foreach (Ingredient ingredient in ApplicationContext.Instance.Ingredient)
			{
				if (ingredient.Name.ToLower().Contains(term.ToLower()) ||
					ingredient.Description.ToLower().Contains(term.ToLower())
					|| medicamentRepository.IsIngedientInMedicament(term, ingredient))
				{
					result.Add(ingredient);
				}
			}

			return result;
		}

		public IEnumerable<Entity> SortByQUantity()
		{
			return ApplicationContext.Instance.Ingredient.OrderBy(x => MedicamentCount((Ingredient)x));
		}


		public int MedicamentCount(Ingredient ingredient) 
		{
			int count = 0;

			foreach(Medicament medicament in ApplicationContext.Instance.Medicament)
            {
				if(medicament.Ingredients.ContainsKey(ingredient))
                {
					count++;
                }
            }

			return count;
		}

		public IEnumerable<Entity> Sort()
        {
			Dictionary<Ingredient, int> dic = new Dictionary<Ingredient, int>();
			foreach(Entity entity in ApplicationContext.Instance.Ingredient)
            {
				dic.Add(entity as Ingredient, MedicamentCount(entity as Ingredient));
            }

			List<Entity> result = new List<Entity>();

			foreach (var item in dic.OrderByDescending(value => value.Value))
            {
				result.Add(item.Key);
            }

			return result;
        }
		
	}
}
