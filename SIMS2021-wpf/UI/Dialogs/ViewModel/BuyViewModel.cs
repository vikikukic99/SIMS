using SIMS2021.CompositeComon;
using SIMS2021.UI.Dialogs.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021_wpf.UI.Dialogs.ViewModel
{
    public class BuyViewModel : ViewModelBase
    {
        private double quantity;
        private RelayCommand okCommand;
        private BuyView view;

        public BuyViewModel(BuyView view) 
        {
            this.view = view;
        }

        public double Quantity 
        {
            get { return quantity; }
            set 
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public RelayCommand OkCommand 
        {
            get { return okCommand ?? (okCommand = new RelayCommand(param => OkCommandExecute(), param => CanOkCommandExecute())); }
        }

        public void OkCommandExecute() 
        {
            view.Close();
        }

        public bool CanOkCommandExecute() 
        {
            return quantity <= 5 && quantity > 0;
        }
    }
}
