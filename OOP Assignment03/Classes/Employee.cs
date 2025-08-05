using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Assignment03.Classes
{

    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        security_officer

    }

    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public SecurityLevel Security { get; set; }

        public decimal salary { get; set; }
        public DateTime hireDate { get; set; }

        private char gender;


        public int ID
        {
            get => id;
            set => id = value >= 0 ? value : throw new ArgumentException("ID must be non-negative.");
        }

        public string Name
        {
            get => name;
            set => name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Name cannot be empty.");
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value >= 0 ? value : throw new ArgumentException("Salary must be non-negative.");
        }


        public DateTime HireDate
        {
            get => hireDate;
            set
            {
                if (value <= DateTime.Today)
                    hireDate = value;
                else
                    throw new ArgumentException("Hire date cannot be in the future.");
            }
        }

        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }



        public Employee()
        {      
        }
        public Employee(int id, string name, char gender, SecurityLevel security, decimal salary, DateTime hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"Employee Info:\nID: {ID}\nName: {Name}\nGender: {(Gender == 'M' ? "Male" : "Female")}\nSecurity Level: {Security}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate.ToShortDateString()}";
        }



    }
}
