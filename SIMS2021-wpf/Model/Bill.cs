using SIMS2021.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
    public class Bill : Entity
    {
        private string farmacist;
        private DateTime date = DateTime.Now;
        private string time;
        private Dictionary<Medicament, double> medicamentsQuantity = new Dictionary<Medicament, double>();
        private float fullPrice;

        public string Farmacist
        {
            get { return farmacist; }
            set
            {
                farmacist = value;
                OnPropertyChanged(nameof(Farmacist));
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public string Time
        {
            get { return time; }
            set
            {
                time = value;
                OnPropertyChanged(nameof(Time));
            }
        }

        public Dictionary<Medicament, double> MedicamentsQuantity
        {
            get { return medicamentsQuantity; }
            set
            {
                medicamentsQuantity = value;
                OnPropertyChanged(nameof(MedicamentsQuantity));
            }
        }

        public float FullPrice
        {
            get { return fullPrice; }
            set
            {
                fullPrice = value;
                OnPropertyChanged(nameof(FullPrice));
            }
        }

        public Bill() : base()
        {
            InitExportList();
        }

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("Farmacist");
            exportList.Add("Time");
            exportList.Add("Date");
            exportList.Add("MedicamentsQuantity");
            exportList.Add("FullPrice");
        }


        public override string Validate(string columnName)
        {
            return string.Empty;
        }
    }
}
