using SIMS2021.Model;
using SIMS2021.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
    public class Patient : Entity
    {
        private string firstName;
        private string lastName;

        public Patient() : base()
        {
            InitExportList();
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("FirstName");
            exportList.Add("LastName");

        }

        public override string Validate(string columnName)
        {
            return "";
        }

        
    }
}
