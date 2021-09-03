using SIMS2021.CompositeComon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS2021.Model
{
    public class Doctor : Entity
    {

        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string speciality;
        private DoctorType doctorType;

        public Doctor() : base()
        {
            InitExportList();
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
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

        public string Speciality
        {
            get { return speciality; }
            set
            {
                speciality = value;
                OnPropertyChanged(nameof(Speciality));
            }
        }

        public DoctorType DoctorType
        {
            get { return doctorType; }
            set
            {
                doctorType = value;
                OnPropertyChanged(nameof(DoctorType));
            }
        }

        public override void InitExportList()
        {
            exportList = new List<string>();
            exportList.Add("ID");
            exportList.Add("Username");
            exportList.Add("Password");
            exportList.Add("FirstName");
            exportList.Add("LastName");
            exportList.Add("Speciality");
            exportList.Add("DoctorType");
        }


        public override string Validate(string columnName)
        {
            return "";
        }

    }
}
