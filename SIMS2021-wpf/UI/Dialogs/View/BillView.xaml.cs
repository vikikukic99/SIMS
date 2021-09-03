using SIMS2021.UI.Dialogs.ViewModel;
using System.Windows;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for BillView.xaml
    /// </summary>
    public partial class BillView : Window
    {
        public BillView()
        {
            InitializeComponent();
            DataContext = new BillViewModel(this);
        }
 
    }
}
