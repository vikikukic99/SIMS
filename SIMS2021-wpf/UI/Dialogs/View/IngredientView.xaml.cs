using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.UI.Dialogs.ViewModel;
using System.Windows;

namespace SIMS2021.UI.Dialogs.View
{
    /// <summary>
    /// Interaction logic for IngredientView.xaml
    /// </summary>
    public partial class IngredientView : Window
    {
        public IngredientView()
        {
            InitializeComponent();
            DataContext = new IngredietViewModel(this);
        }
    }
}
