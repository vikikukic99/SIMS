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

namespace SIMS2021.UI.Dialogs.ViewModel
{
    public class DoctorViewModel : BaseDialogViewModel
    {
        private DoctorRepository repository = new DoctorRepository();
        private DoctorView dialog;
        private List<ComboData<DoctorType>> doctorTypes = new List<ComboData<DoctorType>>();

        public DoctorViewModel(DoctorView view) : base(view, typeof(Doctor))
        {
            dialog = view;
            Init();
            InitDoctorTypes();
        }

        public void InitDoctorTypes()
        {
            doctorTypes.Add(new ComboData<DoctorType> { Name = "Doctor", Value = DoctorType.Doctor });
            doctorTypes.Add(new ComboData<DoctorType> { Name = "Specialist", Value = DoctorType.Special });
        }

        protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

        public List<ComboData<DoctorType>> DoctorTypes
        {
            get { return doctorTypes; }
            set
            {
                doctorTypes = value;
                OnPropertyChanged(nameof(doctorTypes));
            }
        }

        protected override void OkCommandExecute()
        {
            ((Doctor)SelectedItem).Password = dialog.Password;
            base.OkCommandExecute();

            ApplicationContext.Instance.Doctors = new List<Entity>(Items);
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
