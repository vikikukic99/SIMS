using SIMS2021.Persistance;
using SIMS2021_wpf.CompositeComon.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SIMS2021.Model
{
    public class ApplicationContext
    {
        private static ApplicationContext instance = null;
        private List<Entity> doctors = new List<Entity>();
        private List<Entity> patients = new List<Entity>();
        private List<Entity> products = new List<Entity>();
        private List<Entity> medicaments = new List<Entity>();
        private List<Entity> bills = new List<Entity>();
        private List<Entity> users = new List<Entity>();
        private List<Entity> ingredients = new List<Entity>();
        private User user;

        public ApplicationContext()
        {
            
        }

        public static ApplicationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                    instance.Load();
                }

                return instance;
            }
        }

        public User User 
        {
            get { return user; }
            set
            {
                user = value;
            }
        }

        public List<Entity> Doctors
        {
            get { return doctors; }
            set { doctors = value; }
        }

        public List<Entity> Patients
        {
            get { return patients; }
            set { patients = value; }
        }

        public List<Entity> Products
        {
            get { return products; }
            set { products = value; }
        }

        public List<Entity> Users
        {
            get { return users; }
            set { users = value; }
        }

        public List<Entity> Medicament
        {
            get { return medicaments; }
            set { medicaments = value; }
        }

        public List<Entity> Ingredient
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public List<Entity> Bill
        {
            get { return bills; }
            set { bills = value; }
        }
        public IEnumerable<Entity> PersonalId { get; internal set; }

        public DoctorType GetDoctorType(string value)
        {
            if (value == "Doctor")
            {
                return DoctorType.Doctor;
            }

            return DoctorType.Special;
        }

        public UserType GetUserType(string value)
        {
            if (value == "Doctor")
            {
                return UserType.Doctor;
            }
            else if (value == "Farmacist")
            {
                return UserType.Farmacist;
            }
            return UserType.Patient;
        }

        public void LoadDoctors()
        {
            List<Entity> result = new List<Entity>();

            if (!File.Exists("doctors.txt"))
            {
                doctors = result;
                return;
            }

            StreamReader reader = new StreamReader("doctors.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                Doctor doctor = new Doctor();
                doctor.ID = data[0];
                doctor.Username = data[1];
                doctor.Password = data[2];
                doctor.FirstName = data[3];
                doctor.LastName = data[4];
                doctor.DoctorType = GetDoctorType(data[5]);
                result.Add(doctor);
            }

            doctors = result;
        }

        public void LoadPatients()
        {
            List<Entity> result = new List<Entity>();

            if (!File.Exists("patients.txt"))
            {
                patients = result;
                return;
            }

            StreamReader reader = new StreamReader("patients.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                Patient patient = new Patient();
                patient.ID = data[0];
                patient.FirstName = data[1];
                patient.LastName = data[2];
                result.Add(patient);
            }

            patients = result;
        }

        public void LoadProducts()
        {
            List<Entity> result = new List<Entity>();

            if (!File.Exists("products.txt"))
            {
                products = result;
                return;
            }

            StreamReader reader = new StreamReader("products.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');

                Products product = new Products();
                product.ID = data[0];
                product.Name = data[1];
                product.Description = data[2];
                product.Quantity = data[2] != null && data[2] != string.Empty ? double.Parse(data[2]) : 0;
                result.Add(product);
            }

            products = result;
        }


        public void LoadUsers()
        {
            List<Entity> result = new List<Entity>();
            if(!File.Exists("users.txt"))
            {
                users = result;
                return;
            }

            StreamReader reader = new StreamReader("users.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                User user = new User();
                user.ID = data[0];
                user.PersonalId = data[1];
                user.Email = data[2];
                user.Password = data[3];
                user.Name = data[4];
                user.Surname = data[5];
                user.Phone = data[6];
                user.UserType = GetUserType(data[7]);
                users.Add(user);
            }
        }

        public void LoadMedicaments()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("medicaments.txt"))
            {
                medicaments = result;
                return;
            }


            StreamReader reader = new StreamReader("medicaments.txt");
            string line;
            IngredientRepository ingredientRepository = new IngredientRepository();

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Medicament medicament = new Medicament();
                medicament.ID = data[0];
                medicament.Name = data[1];
                medicament.Manufacturer = data[2];
                medicament.Price = float.Parse(data[3]);
                medicament.Quantity = int.Parse(data[4]);
                medicament.Accepted = bool.Parse(data[5]);
                medicament.Deleted = bool.Parse(data[6]);
                medicament.Reason = data[8];


                string[] ingredients = data[7].Split(',');

                foreach(string ing in ingredients)
                {
                    string[] ingData = ing.Split(';');
                    if(ingData.Length <2)
                    {
                        continue;
                    }

                    medicament.Ingredients.Add((Ingredient)ingredientRepository.Get(ingData[0]), int.Parse(ingData[1]));
                }

                medicaments.Add(medicament);
            }
        }


        public void LoadIngredients()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("ingredients.txt"))
            {
                ingredients = result;
                return;
            }

            StreamReader reader = new StreamReader("ingredients.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Ingredient ingredient = new Ingredient();
                ingredient.ID = data[0];
                ingredient.Name = data[1];
                ingredient.Description = data[2];

                ingredients.Add(ingredient);
            }

        }


        public void LoadBills()
        {
            List<Entity> result = new List<Entity>();
            if (!File.Exists("bills.txt"))
            {
                bills = result;
                return;
            }

            StreamReader reader = new StreamReader("bills.txt");
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                Bill bill = new Bill();
                bill.ID = data[0];
                bill.Farmacist = data[1];
                bill.Date = DateTime.Parse(data[2]);
                bill.Time = data[3];
                bill.FullPrice = float.Parse(data[4]);

                bills.Add(bill);
            }
        }

        public void SaveDoctors()
        {
            if (doctors == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("doctors.txt"))
            {
                foreach (Entity entity in doctors)
                {
                    string line = string.Empty;

                    line += ((Doctor)entity).ID + "|";
                    line += ((Doctor)entity).Username + "|";
                    line += ((Doctor)entity).Password + "|";
                    line += ((Doctor)entity).FirstName + "|";
                    line += ((Doctor)entity).LastName + "|";
                    line += ((Doctor)entity).Speciality + "|";
                    line += ((Doctor)entity).DoctorType.ToString();

                    file.WriteLine(line);
                }
            }
        }

        public void SavePatients()
        {
            if (patients == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("patients.txt"))
            {
                foreach (Entity entity in patients)
                {
                    string line = string.Empty;

                    line += ((Patient)entity).ID + "|";
                    line += ((Patient)entity).FirstName + "|";
                    line += ((Patient)entity).LastName;

                    file.WriteLine(line);
                }
            }
        }

        public void SaveProducts()
        {
            if (products == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("products.txt"))
            {
                foreach (Entity entity in products)
                {
                    string line = string.Empty;

                    line += ((Products)entity).ID + "|";
                    line += ((Products)entity).Name + "|";
                    line += ((Products)entity).Description + "|";
                    line += ((Products)entity).Quantity.ToString();

                    file.WriteLine(line);
                }
            }
        }

        public void SaveUser()
        {
            if (users == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("users.txt"))
            {
                foreach (Entity entity in users)
                {
                    string line = string.Empty;

                    line += ((User)entity).ID + "|";
                    line += ((User)entity).PersonalId + "|";
                    line += ((User)entity).Email + "|";
                    line += ((User)entity).Password + "|";
                    line += ((User)entity).Name + "|";
                    line += ((User)entity).Surname + "|";
                    line += ((User)entity).Phone + "|";
                    line += ((User)entity).UserType.ToString();

                    file.WriteLine(line);
                }
            }
        }

        public void SaveMedicaments()
        {
            if (medicaments == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("medicaments.txt"))
            {
                foreach (Entity entity in medicaments)
                {
                    string line = string.Empty;

                    line += ((Medicament)entity).ID + "|";
                    line += ((Medicament)entity).Name + "|";
                    line += ((Medicament)entity).Manufacturer + "|";
                    line += ((Medicament)entity).Price + "|";
                    line += ((Medicament)entity).Quantity + "|";
                    line += ((Medicament)entity).Accepted + "|";
                    line += ((Medicament)entity).Deleted + "|";
                    

                    foreach (KeyValuePair<Ingredient, double> ing in ((Medicament)entity).Ingredients)
                    {
                        line += ing.Key.ID + ";" + ing.Value + ",";
                    }

                    line += ((Medicament)entity).Reason + "|";

                    file.WriteLine(line);
                }
            }
        }



        public void SaveIngredients()
        {
            if (ingredients == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("ingredients.txt"))
            {
                foreach (Entity entity in ingredients)
                {
                    string line = string.Empty;

                    line += ((Ingredient)entity).ID + "|";
                    line += ((Ingredient)entity).Name + "|";
                    line += ((Ingredient)entity).Description;

                    file.WriteLine(line);
                }
            }
        }



        public void SaveBills()
        {
            if (bills == null)
            {
                return;
            }

            using (StreamWriter file = new StreamWriter("bills.txt"))
            {
                foreach (Entity entity in bills)
                {
                    string line = string.Empty;

                    line += ((Bill)entity).ID + "|";
                    line += ((Bill)entity).Farmacist + "|";
                    line += ((Bill)entity).Date + "|";
                    line += ((Bill)entity).Time + "|";
                    line += ((Bill)entity).FullPrice + "|";

                    file.WriteLine(line);
                }
            }
        }


        public List<Entity> Get(Type type)
        {
            if (type == typeof(Doctor))
            {
                return Doctors;
            }

            if (type == typeof(Patient))
            {
                return Patients;
            }

            if (type == typeof(Ingredient))
            {
                return Ingredient;
            }

            if (type == typeof(User))
            {
                return users;
            }

            if (type == typeof(Medicament))
            {
                return Medicament;
            }

            if (type == typeof(Bill))
            {
                return Bill;
            }

            return Products;
        }

        public void Set(Type type, List<Entity> entities)
        {
            if (type == typeof(Doctor))
            {
                Doctors = entities;
                return;
            }

            if (type == typeof(Patient))
            {
                Patients = entities;
                return;
            }

            if (type == typeof(Products))
            {
                Products = entities;
                return;
            }

            if (type == typeof(User))
            {
                Users = entities;
                return;
            }

            if (type == typeof(Medicament))
            {
                Medicament = entities;
                return;
            }

            if (type == typeof(Ingredient))
            {
                Ingredient = entities;
                return;
            }

            if (type == typeof(Bill))
            {
                Bill = entities;
                return;
            }

        }

        public void Save()
        {
            SaveDoctors();
            SavePatients();
            SaveProducts();
            SaveUser();
            SaveMedicaments();
            SaveIngredients();
            SaveBills();
        }

        public void Load()
        {
            LoadDoctors();
            LoadPatients();
            LoadProducts();
            LoadUsers();
            LoadIngredients();
            LoadMedicaments();
            LoadBills();
        }
    }
}
