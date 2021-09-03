using SIMS2021.CompositeComon;
using SIMS2021_wpf.CompositeComon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
   public  class User : Entity
    {
        private string personalId;
        private string email;
        private string password;
        private string name;
        private string surname;
        private string phone;
        private UserType userType;

        public User() : base()
        {
            InitExportList();
        }

        public string PersonalId
        {
            get { return personalId; }
            set
            {
                personalId = value;
                OnPropertyChanged(nameof(PersonalId));
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
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


        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }


        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        public UserType UserType
        {
            get { return userType; }
            set
            {
                userType = value;
                OnPropertyChanged(nameof(UserType));
            }
        }

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("PersonalId");
            exportList.Add("Email");
            exportList.Add("Password");
            exportList.Add("Name");
            exportList.Add("Surname");
            exportList.Add("Phone");
            exportList.Add("UserType");
        }

        public override string Validate(string columnName)
        {
            return string.Empty;
        }

       
    }



}