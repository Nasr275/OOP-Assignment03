using OOP_Assignment03.Classes;

namespace OOP_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //    try
            //    {
            //        Employee emp = new Employee
            //        {
            //            ID = 1,
            //            Name = "Abdelrahman Nasr",
            //            Gender = 'M',
            //            Security = SecurityLevel.Developer,
            //            Salary = 7500.50m,
            //            HireDate = new DateTime(2022, 3, 15)
            //        };

            //        Console.WriteLine(emp);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
            //}
            #endregion

            #region Q2 Develop a Class to represent the Hiring Date Data

            //try
            //{
            //    HiringDate hireDate = new HiringDate(01, 09, 2024);
            //    Console.WriteLine("Hiring Date: " + hireDate);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            #endregion

            #region Q3

            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee(1, "Ahmed Gamal", 'M', SecurityLevel.DBA, 15000.50m, new DateTime(2021, 6, 1));

            EmpArr[1] = new Employee(2, "Salma Fathy", 'F', SecurityLevel.Guest, 5000.00m, new DateTime(2023, 2, 12));

            EmpArr[2] = new Employee(3, "Khaled Tarek", 'M', SecurityLevel.security_officer, 18000.00m, new DateTime(2020, 11, 5));


            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
                Console.WriteLine("---------------------------------------------------------------");
            }

            #endregion
        }
    }
}

