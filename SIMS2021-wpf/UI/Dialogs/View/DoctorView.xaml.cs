using SIMS2021.UI.Dialogs.ViewModel;
using System.Windows;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for DoctorView.xaml
    /// </summary>
    public partial class DoctorView : Window
    {
        public DoctorView()
        {
            InitializeComponent();
            DataContext = new DoctorViewModel(this);
        }

        public string Password
        {
            get
            {
                if (password == null || password.Password == null)
                {
                    return string.Empty;
                }

                return password.Password.ToString();
            }
        }
    }
}
