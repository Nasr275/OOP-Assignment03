using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03.Classes
{

    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA

    }

    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public SecurityLevel Security { get; set; }

        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        private char gender;
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

        public override string ToString()
        {
            return $"Employee Info:\nID: {ID}\nName: {Name}\nGender: {(Gender == 'M' ? "Male" : "Female")}\nSecurity Level: {Security}\nSalary: {String.Format("{0:C}", Salary)}\nHire Date: {HireDate.ToShortDateString()}";
        }



    }
}
