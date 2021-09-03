
using SIMS021;
using SIMS2021.CompositeComon;
using SIMS2021.Model;
using SIMS2021.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SIMS2021.UI.Components.Login.ViewModel
{
	public class LoginViewModel : ViewModelBase
	{
		private string username;
		private string password;
		private RelayCommand loginCommand;
		private RelayCommand cancelCommand;
		private Window dialog;
		private PasswordBox passwordBox;
		private MainWindowViewModel mainViewModel;

		public LoginViewModel(Window dialog, PasswordBox passwordBox, MainWindowViewModel mainViewModel)
		{
			this.dialog = dialog;
			this.passwordBox = passwordBox;
			this.mainViewModel = mainViewModel;

		}

		public string Username
		{
			get { return username; }
			set
			{
				username = value;
				OnPropertyChanged(nameof(Username));
			}
		}

		public string Password
		{
			get { return password; }
			set
			{
				password = value;
				OnPropertyChanged(nameof(Password));
			}
		}

		#region Command Properties

		public RelayCommand LoginCommand
		{
			get
			{
				return loginCommand ?? (loginCommand = new RelayCommand(param => LoginCommandExecute(), param => CanLoginCommandExecute()));
			}
		}

		public RelayCommand CancelCommand
		{
			get
			{
				return cancelCommand ?? (cancelCommand = new RelayCommand(param => CancelCommandExecute(), param => CanCancelCommandExecute()));
			}
		}

		#endregion

		private void LoginCommandExecute()
		{
			
			UserRepository repository = new UserRepository();
			User user = repository.GetUserWIthUsernameAndPassword(Username, Password);

			if (user == null)
			{
				MessageBox.Show("Wrong username or password", "Error login!");
				return;
			}

			ApplicationContext.Instance.User = user;
			
			dialog.Close();
		}

		private bool CanLoginCommandExecute()
		{
			return !string.IsNullOrEmpty(Username);
		}

		private void CancelCommandExecute()
		{
			System.Windows.Application.Current.Shutdown();
		}

		private bool CanCancelCommandExecute()
		{
			return true;
		}
	}
}
