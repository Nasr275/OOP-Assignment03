using OOP_Assignment03.Classes;

namespace OOP_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region
            try
            {
                Employee emp = new Employee
                {
                    ID = 1,
                    Name = "Abdelrahman Nasr",
                    Gender = 'M',
                    Security = SecurityLevel.Developer,
                    Salary = 7500.50m,
                    HireDate = new DateTime(2022, 3, 15)
                };

                Console.WriteLine(emp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion

    }
    }

