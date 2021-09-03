using SIMS2021.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
    public class Ingredient : Entity
    {
        private string name;
        private string description;

        public Ingredient() : base() 
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

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("Name");
            exportList.Add("Description");
        }

        public override string Validate(string columnName)
        {
            return string.Empty;
        }

        public override bool Equals(object obj)
        {
            Ingredient ingredient = obj as Ingredient;

            if (ingredient == null) 
            {
                return false;
            }

            return ID == ingredient.ID;
        }
    }

}
