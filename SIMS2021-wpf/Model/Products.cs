using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
    public class Products : Entity
    {
        private string name;
        private string description;
        private double quantity;

        public Products() : base()
        {
            InitExportList();
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

        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
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

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("Name");
            exportList.Add("Description");
            exportList.Add("Quantity");
        }

        public override string Validate(string columnName)
        {
            return "";
        }


    }
}
