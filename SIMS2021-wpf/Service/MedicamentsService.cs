using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.Service
{
    public class MedicamentsService : BaseService<Medicament>
    {
        public MedicamentsService()
        {
            repository = new MedicamentRepository();
        }

		public IEnumerable<Entity> GetAllWaiting()
		{
			return ((MedicamentRepository)repository).GetAllWaiting();
		}
		public bool IsIngedientInMedicament(string medicamentName, Ingredient ingredient)
		{
			return ((MedicamentRepository)repository).IsIngedientInMedicament(medicamentName, ingredient);
		}

		public override IEnumerable<Entity> GetAll()
		{
			return ((MedicamentRepository)repository).GetAll();
		}

		public IEnumerable<Entity> SearchPrice(double priceFrom, double priceTo)
		{
			return ((MedicamentRepository)repository).SearchPrice(priceFrom, priceTo);
		}

		public IEnumerable<Entity> SearchByIngredient(string term)
		{
			return ((MedicamentRepository)repository).SearchByIngredient(term);
		}

	}

}
