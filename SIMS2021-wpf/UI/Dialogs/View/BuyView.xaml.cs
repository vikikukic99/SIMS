using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.UI.Dialogs.ViewModel;
using System.Windows;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for BuyView.xaml
    /// </summary>
    public partial class BuyView : Window
    {
        public BuyViewModel ViewModel;
        public BuyView()
        {
            InitializeComponent();
            ViewModel = new BuyViewModel(this);
            DataContext = ViewModel;
        }

    }
}
