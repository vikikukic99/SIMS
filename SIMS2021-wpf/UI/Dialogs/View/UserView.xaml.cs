using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.UI.Dialogs.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        UserViewModel userViewModel;

        public UserView()
        {
            InitializeComponent();
            userViewModel = new UserViewModel(this);
            DataContext = userViewModel;
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            if ((passwordBox != null))
            {
                userViewModel.Password = passwordBox.Password;
            }
        }
    }
}
