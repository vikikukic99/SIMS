using SIMS2021.Model;
using SIMS2021.Persistance;
using SIMS2021.UI.Dialogs.View;
using SIMS2021.UI.Dialogs.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS2021.CompositeComon.Enums;
using SIMS2021.CompositeComon;
using SIMS2021_wpf.Service;

namespace SIMS2021_wpf.UI.Dialogs.ViewModel
{
    public class IngredietViewModel : BaseDialogViewModel
    {
        private IngredientService repository = new IngredientService();
        private RelayCommand sortByMedicamentsFrequency;

        public IngredietViewModel(IngredientView view) : base(view, typeof(Ingredient))
        {
            Init();
        }

        public RelayCommand SortByMedicamentsFrequency
        {
            get
            {
                return sortByMedicamentsFrequency ?? (sortByMedicamentsFrequency = new RelayCommand(param => this.SortByMedicamentsFrequencyExecute()));
            }
        }

        protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

        protected void SortByMedicamentsFrequencyExecuteExecute()
        {
            Items = new ObservableCollection<Entity>(repository.SortByQUantity());
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Ingredient = new List<Entity>(Items);
            repository.Save();
            Init();
        }

        protected override Entity OkAfterAddDatabase()
        {
            return SelectedItem;
        }

        protected override Entity OkAfterEditDatabase()
        {
            repository.Save();
            return SelectedItem;
        }

        protected override bool DatabaseRemove(Entity item)
        {
            repository.Remove(item);
            repository.Save();
            return true;
        }

        protected void SortByMedicamentsFrequencyExecute()
        {
            Items = new ObservableCollection<Entity>(repository.Sort());
        }


        protected override void DoSearch()
        {
            Items = new ObservableCollection<Entity>(repository.Search(Search));
        }
    }
}
