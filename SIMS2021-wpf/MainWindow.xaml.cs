using SIMS021;
using SIMS2021.UI.Components.Login.View;
using SIMS2021.UI.Components.Toolbar.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SIMS2021_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            LoginView view = new LoginView(DataContext as MainWindowViewModel);
            view.ShowDialog();
            InitializeComponent();
            MainWindowViewModel mainViewModel = new MainWindowViewModel();

            DataContext = mainViewModel;
            

            ((ToolbarViewModel)toolbar.DataContext).MainWindowViewModel = mainViewModel;

            mainViewModel.ToolbarViewModel = (ToolbarViewModel)toolbar.DataContext;
            


        }
    }
}
