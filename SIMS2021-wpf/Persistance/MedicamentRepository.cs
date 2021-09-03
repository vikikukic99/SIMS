using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Persistance
{
    class MedicamentRepository  : Repository<Medicament>
    {

		public IEnumerable<Entity> GetAllWaiting()
		{
			List<Entity> result = new List<Entity>();

			foreach (Medicament entity in ApplicationContext.Instance.Medicament)
			{
				if (!entity.Accepted && !entity.Deleted)
				{
					result.Add(entity);
				}
			}

			return result;
		}
		public bool IsIngedientInMedicament(string medicamentName, Ingredient ingredient) 
		{
			foreach(Medicament medicament in ApplicationContext.Instance.Medicament) 
			{
				if (!medicament.Name.ToLower().Contains(medicamentName.ToLower())) 
				{
					continue;
				}

				if (medicament.Ingredients.ContainsKey(ingredient)) 
				{
					return true;
				}
			}


			return false;
		}

		public override IEnumerable<Entity> GetAll()
		{
			List<Entity> result = new List<Entity>();

			foreach (Medicament entity in ApplicationContext.Instance.Medicament)
			{
				if (!entity.Deleted)
				{
					result.Add(entity);
				}
			}

			return result;
		}


		public override IEnumerable<Entity> Search(string term = "")
		{
			List<Entity> result = new List<Entity>();

			foreach (Entity entity in ApplicationContext.Instance.Medicament)
			{
				if (((Medicament)entity).ID.ToLower().Contains(term.ToLower()) || ((Medicament)entity).Name.ToLower().Contains(term.ToLower())
					|| ((Medicament)entity).Manufacturer.ToLower().Contains(term.ToLower()) || ((Medicament)entity).Quantity.ToString().Contains(term.ToLower()))
				{
					result.Add(entity);
				}
			}

			return result;
		}

		public IEnumerable<Entity> SearchPrice(double priceFrom, double priceTo)
		{
			List<Entity> prices = new List<Entity>();

			foreach (Entity entity in ApplicationContext.Instance.Medicament)
			{
				if (((Medicament)entity).Price >= priceFrom && ((Medicament)entity).Price <= priceTo)
				{
					prices.Add(entity);
				}
			}
			return prices;
		}

		public IEnumerable<Entity> SearchByIngredient(string term)
		{
			List<Entity> result = new List<Entity>();

			string[] terms = term.Split('|');

			foreach (string s in terms) 
			{
				

				foreach (Entity entity in ApplicationContext.Instance.Medicament)
				{
					bool found = false;

					foreach (KeyValuePair<Ingredient, double> pair in ((Medicament)entity).Ingredients)
					{

						if (found)
						{
							break;
						}

						if (pair.Key.Name.Contains(s))
						{
							result.Add(entity);
							found = true;
						}

					}

					if (found)
					{
						break;
					}
				}
			}

			
			return result;
		}

	}


}
