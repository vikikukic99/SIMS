using SIMS2021.Model;
using SIMS2021.Persistance;
using SIMS2021.UI.Dialogs.Model;
using SIMS2021.UI.Dialogs.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS2021_wpf.Persistance;
using SIMS2021_wpf.Service;

namespace SIMS2021.UI.Dialogs.ViewModel
{
    public class BillViewModel : BaseDialogViewModel
    {
        private BillService repository = new BillService();
        private List<ComboData<Medicament>> medicaments = new List<ComboData<Medicament>>();
        private Medicament medicament;

        public BillViewModel(BillView view) : base(view, typeof(Bill))
        {
            Init();
            LoadMedicaments();
        }

        public void LoadMedicaments()
        {
            foreach (Medicament medic in ApplicationContext.Instance.Medicament)
            {
                medicaments.Add(new ComboData<Medicament>() { Name = medic.Name, Value = medic });
            }

        }

        public List<ComboData<Medicament>> Medicaments
        {
            get { return medicaments; }
            set 
            {
                medicaments = value;
            }
        }

        public Medicament Medicamet
        {
            get { return medicament; }
            set
            {
                medicament = value;
                OnPropertyChanged(nameof(Medicament));
            }
        }

        protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Bill = new List<Entity>(Items);
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

        protected override void DoSearch()
        {
            Items = new ObservableCollection<Entity>(repository.Search(Search));
        }
    }
}
