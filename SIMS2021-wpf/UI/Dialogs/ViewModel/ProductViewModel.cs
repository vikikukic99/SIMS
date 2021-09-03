
using SIMS2021.Model;
using SIMS2021.Persistance;
using SIMS2021.UI.Dialogs.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.UI.Dialogs.ViewModel
{
    public class ProductViewModel : BaseDialogViewModel
    {
        private ProductRepository repository = new ProductRepository();

        public ProductViewModel(ProductView view) : base(view, typeof(Products))
        {
            Init();
        }

        protected override void Init()
        {
            Items = new ObservableCollection<Entity>(repository.GetAll());
        }

        protected override void OkCommandExecute()
        {
            base.OkCommandExecute();

            ApplicationContext.Instance.Products = new List<Entity>(Items);
            repository.Save();
            Init();
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
    }
}
