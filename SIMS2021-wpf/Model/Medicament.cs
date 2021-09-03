using SIMS2021.CompositeComon;
using SIMS2021.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
     public class Medicament : Entity
    {
        private string iD;
        private string name;
        private string manufacturer;
        private float price;
        private int quantity;
        private Dictionary<Ingredient, double> ingredients = new Dictionary<Ingredient, double>();      //koliko i kojih sastojaka moram da znam tu info
        private Boolean accepted;
        private Boolean deleted;
        private string reason;
        //private UserType userType;


        public  Medicament() : base()
        {
            InitExportList();
        }

        public string ID
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(ID));
            }
        }

        public string Reason
        {
            get { return reason; }
            set
            {
                reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                OnPropertyChanged(nameof(Manufacturer));
            }
        }


        public float Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }


        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }


        public Dictionary<Ingredient, double> Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }


        public Boolean Accepted
        {
            get { return accepted; }
            set
            {
                accepted = value;
                OnPropertyChanged(nameof(Accepted));
            }
        }

        public Boolean Deleted
        {
            get { return deleted; }
            set
            {
                deleted = value;
                OnPropertyChanged(nameof(Deleted));
            }
        }


        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("Name");
            exportList.Add("Manufacturer");
            exportList.Add("Price");
            exportList.Add("Quantity");
            exportList.Add("Ingredients");
            exportList.Add("Accepted");
            exportList.Add("Deleted");
        }



        public override string Validate(string columnName)
        {
            return string.Empty;
        }

     }






}
