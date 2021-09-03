using SIMS2021.CompositeComon;
using SIMS2021.Model;
using SIMS2021.Persistance;
using SIMS2021.UI.Dialogs.Model;
using SIMS2021.UI.Dialogs.View;
using SIMS2021.UI.Dialogs.ViewModel;
using SIMS2021_wpf.CompositeComon.Enums;
using SIMS2021_wpf.UI.Dialogs.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIMS2021.CompositeComon.Enums;
using System.Windows;
using SIMS2021_wpf.Service;

namespace SIMS2021_wpf.UI.Dialogs.ViewModel
{
    public class MedicamentViewModel : BaseDialogViewModel
    {
        private MedicamentsService repository = new MedicamentsService();
        private List<ComboData<Ingredient>> ingredients = new List<ComboData<Ingredient>>();
        private Ingredient ingredient;
        private double quantity;
        private double priceFrom;
        private double priceTo;
        private string medicamentIngredient;
        private RelayCommand searchByPriceCommand;
        private RelayCommand addForIngredientsCommand;
        private RelayCommand searchByIngredientCommand;
        private RelayCommand addToCardCommand;
        private RelayCommand buyCommand;
        private Bill selectedBill = new Bill();

        public MedicamentViewModel(MedicamentView view) : base(view, typeof(Medicament))
        {
            Init();
            LoadIngredients();
        }

        public void LoadIngredients()
        {
            foreach (Ingredient ingr in ApplicationContext.Instance.Ingredient)
            {
                ingredients.Add(new ComboData<Ingredient>() { Name = ingr.Name, Value = ingr });
            }
        }

        public List<ComboData<Ingredient>> Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
            }
        }


        public RelayCommand AddToCardCommand
        {
            get
            {
                return addToCardCommand ?? (addToCardCommand = new RelayCommand(param => this.AddToCardCommandExecute()));
            }
        }

        public RelayCommand BuyCommand
        {
            get
            {
                return buyCommand ?? (buyCommand = new RelayCommand(param => this.BuyCommandExecute()));
            }
        }

        public RelayCommand SearchByPriceCommand
        {
            get
            {
                return searchByPriceCommand ?? (searchByPriceCommand = new RelayCommand(param => this.SearchByPriceCommandExecute(), param => this.CanSearchByPriceCommandExecute()));
            }
        }

        public RelayCommand AddForIngredientsCommand
        {
            get
            {
                return addForIngredientsCommand ?? (addForIngredientsCommand = new RelayCommand(param => this.AddForIngredientsCommandExecute(), param => this.CanAddForIngredientsCommandExecute()));
            }
        }

        public RelayCommand SearchByIngridientCommand
        {
            get
            {
                return searchByIngredientCommand ?? (searchByIngredientCommand = new RelayCommand(param => this.SearchByIngredientCommandExecute()));
            }
        }

        public override Entity SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                    OnPropertyChanged(nameof(MedicamentIngredients));
                }
            }
        }


        public ObservableCollection<TableData> MedicamentIngredients 
        {
            get 
            {
                ObservableCollection<TableData> data = new ObservableCollection<TableData>();

                if (SelectedItem == null) 
                {
                    return data;
                }

                foreach (KeyValuePair<Ingredient, double> pair in ((Medicament)SelectedItem).Ingredients) 
                {
                    data.Add(new TableData() { Name = pair.Key.Name, Quantity = pair.Value });
                }


                return data;
            }
        }

        public void AddToCardCommandExecute() 
        {
            BuyView buyView = new BuyView();
            buyView.ShowDialog();


            selectedBill.MedicamentsQuantity.Add((Medicament)SelectedItem, buyView.ViewModel.Quantity);
        }

        public Ingredient Ingredient 
        {
            get { return ingredient; }
            set 
            {
                ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }

        public string MedicamentIngredient
        {
            get { return medicamentIngredient; }
            set
            {
                medicamentIngredient = value;
                OnPropertyChanged(nameof(MedicamentIngredient));
            }
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

        public double PriceFrom
        {
            get { return priceFrom; }
            set { priceFrom = value; }
        }

        public double PriceTo
        {
            get { return priceTo; }
            set { priceTo = value; }
        }

        protected override void Init()
        {
            if (ApplicationContext.Instance.User.UserType == UserType.Doctor)
            {
                Items = new ObservableCollection<Entity>(repository.GetAllWaiting());
            }
            else 
            {
                Items = new ObservableCollection<Entity>(repository.GetAll());
            }
            
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Medicament = new List<Entity>(Items);
            repository.Save();
            Init();
        }

        protected void BuyCommandExecute()
        {
            int id = 0;

            foreach (Bill bill in ApplicationContext.Instance.Bill) 
            {
                int newId = int.Parse(bill.ID);

                if (newId > id) 
                {
                    id = newId;
                }
            }

            foreach (KeyValuePair<Medicament, double> pari in selectedBill.MedicamentsQuantity) 
            {
                selectedBill.FullPrice += (float)(pari.Key.Price * pari.Value); 
            }

            selectedBill.ID = (id + 1).ToString();
            selectedBill.Farmacist = ApplicationContext.Instance.User.Name + " " + ApplicationContext.Instance.User.Surname;
            selectedBill.Date = DateTime.Now;
            selectedBill.Time = DateTime.Now.Hour + ":" + DateTime.Now.Minute;

            ApplicationContext.Instance.Bill.Add(selectedBill);
            ApplicationContext.Instance.Save();
        }

        protected void SearchByPriceCommandExecute()
        {
            Items = new ObservableCollection<Entity>(repository.SearchPrice(priceFrom, priceTo));
        }

        protected bool CanSearchByPriceCommandExecute()
        {
            return priceTo != priceFrom && priceTo > priceFrom;
        }

        protected void AddForIngredientsCommandExecute()
        {
            if (((Medicament)SelectedItem).Ingredients.ContainsKey(Ingredient))   //ovo radim ako bi mi se potrefila ista vrednost program bi mi pukao..
            {
                ((Medicament)SelectedItem).Ingredients[Ingredient] = Quantity;
            }
            else 
            {
                ((Medicament)SelectedItem).Ingredients.Add(Ingredient, Quantity);
            }

            OnPropertyChanged(nameof(MedicamentIngredients));

            repository.Save();
        }

        protected void SearchByIngredientCommandExecute()
        {
            Items = new ObservableCollection<Entity>(repository.SearchByIngredient(MedicamentIngredient));
        }

        protected bool CanAddForIngredientsCommandExecute()
        {
            return Ingredient != null && Quantity > 0;
        }

        protected override bool CanDeleteCommandExecute()
        {
            if (ApplicationContext.Instance.User.UserType == UserType.Patient || ApplicationContext.Instance.User.UserType == UserType.Doctor)
            {
                return false;
            }

            return SelectedItem != null && DialogState == DialogState.View;
        }

        protected override bool CanAddCommandExecute()
        {
            if (ApplicationContext.Instance.User.UserType == UserType.Patient || ApplicationContext.Instance.User.UserType == UserType.Doctor)
            {
                return false;
            }

            return DialogState == DialogState.View;
        }

        protected override Entity OkAfterAddDatabase()
        {
            return SelectedItem;
        }

        protected override Entity OkAfterEditDatabase()
        {
            repository.Save();
            return SelectedItem;
        }

        protected override bool DatabaseRemove(Entity item)
        {
            repository.Remove(item);
            repository.Save();
            return true;
        }

        protected override void DoSearch()
        {
            Items = new ObservableCollection<Entity>(repository.Search(Search));
        }

        public bool CanChangeField 
        {
            get
            {
                return ApplicationContext.Instance.User.UserType == UserType.Farmacist;
            }
        }

        protected override void DeleteCommandExecute()
        {
            MessageBoxResult result = MessageBox.Show("Do you want to delete this item?", "Delete confirm!", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                return;
            }

            ((Medicament)SelectedItem).Deleted = true;
            repository.Save();
            Init();
        }
    }
}
