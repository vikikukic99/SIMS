using SIMS2021.Model;
using SIMS2021.Persistance;
using SIMS2021.UI.Dialogs.Model;
using SIMS2021.UI.Dialogs.View;
using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.CompositeComon.Enums;
using SIMS2021_wpf.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.UI.Dialogs.ViewModel
{
    public class UserViewModel : BaseDialogViewModel
    {
        private UserService repository = new UserService();
        private List<ComboData<UserType>> userTypes = new List<ComboData<UserType>>();

        public UserViewModel(UserView view) : base(view, typeof(User))
        {
            Init();
            LoadUserTypes();
        }

        public List<ComboData<UserType>> UserTypes 
        {
            get { return userTypes; }
        }

        public string Password 
        {
            get;set;
        }

        public void LoadUserTypes() 
        {
            userTypes.Add(new ComboData<UserType>() { Name = "Doctor", Value = UserType.Doctor });
            userTypes.Add(new ComboData<UserType>() { Name = "Farmacist", Value = UserType.Farmacist });
            userTypes.Add(new ComboData<UserType>() { Name = "Patient", Value = UserType.Patient });
        }

        protected override void Init()
        {
            if (ApplicationContext.Instance.User.UserType == UserType.Doctor)
            {
                Items = new ObservableCollection<Entity>(repository.GetAllPatients());
            }
            else 
            {
                Items = new ObservableCollection<Entity>(repository.GetAll());
            }
        }

        protected override bool OkAfterAdd()
        {
            if (SelectedItem.HasErrors())
            {
                return false;
            }

            if (OkAfterAddDatabase() == null)
            {
                return false;
            }

            ((User)SelectedItem).Password = Password;
            ((User)SelectedItem).UserType = UserType.Patient;
            Items.Add(SelectedItem);

            return true;
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Users = new List<Entity>(Items);
            repository.Save();
            Init();

            ((UserView)dialog).password.Password = string.Empty;
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
