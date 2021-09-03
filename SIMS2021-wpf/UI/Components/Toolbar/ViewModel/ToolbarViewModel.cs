
using SIMS021;
using SIMS2021.CompositeComon;
using SIMS2021.Model;
using SIMS2021.UI.Dialogs.View;
using SIMS2021_wpf.CompositeComon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.UI.Components.Toolbar.ViewModel
{
	public class ToolbarViewModel : ViewModelBase
	{
		private RelayCommand medicamentCommand;
		private RelayCommand ingredientCommand;
		private RelayCommand userCommand;
		private RelayCommand billCommand;
		private RelayCommand doctorCommand;

		private MainWindowViewModel mainWindowViewModel;
		public MainWindowViewModel MainWindowViewModel
		{
			get { return mainWindowViewModel; }
			set { mainWindowViewModel = value; }
		}


		public RelayCommand MedicamentCommand
		{
			get
			{
				return medicamentCommand ?? (medicamentCommand = new RelayCommand(param => MedicamentCommandExecute()));
			}
		}


		public RelayCommand IngredientCommand
		{
			get
			{
				return ingredientCommand ?? (ingredientCommand = new RelayCommand(param => IngredientCommandExecute()));
			}
		}

		public RelayCommand UserCommand
		{
			get
			{
				return userCommand ?? (userCommand = new RelayCommand(param => UserCommandExecute(), ParamArrayAttribute => UserCommandCanExecute()));
			}
		}

		public RelayCommand BillCommand
		{
			get
			{
				return billCommand ?? (billCommand = new RelayCommand(param => BillCommandExecute()));
			}
		}

		public RelayCommand DoctorCommand
		{
			get
			{
				return doctorCommand ?? (doctorCommand = new RelayCommand(param => DoctorCommandExecute()));
			}
		}

		public void MedicamentCommandExecute()
		{
			MedicamentView view = new MedicamentView();
			view.ShowDialog();
		}

		public void UserCommandExecute()
		{
			UserView view = new UserView();
			view.ShowDialog();
		}

		public void BillCommandExecute()
		{
			BillView view = new BillView();
			view.ShowDialog();
		}

		public void IngredientCommandExecute()
		{
			IngredientView view = new IngredientView();
			view.ShowDialog();
		}

		public void DoctorCommandExecute()
		{
			DoctorView view = new DoctorView();
			view.ShowDialog();
		}

		public bool UserCommandCanExecute() 
		{
			return ApplicationContext.Instance.User.UserType == UserType.Doctor;
		}
	}
}
