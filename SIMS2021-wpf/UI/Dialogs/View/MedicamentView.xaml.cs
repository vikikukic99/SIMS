using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.UI.Dialogs.ViewModel;
using System.Windows;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for MedicamentView.xaml
    /// </summary>
    public partial class MedicamentView : Window
    {
        public MedicamentView()
        {
            InitializeComponent();
            DataContext = new MedicamentViewModel(this);
        }

    }
}
