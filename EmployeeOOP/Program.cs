using EmployeeOOP.Classes;
using System;

namespace EmployeeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("OOP APPLICATION");
                Console.WriteLine("---------------");
                Console.WriteLine("* COMMISSION EMPLOYEE *");
                Console.WriteLine("---------------");
                //Declarar algunas variables
                int day, month, year, id;
                string firstName, lastName;
                decimal salary;

                Console.Write("Ingresar el día: ");
                day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el mes: ");
                month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el año: ");
                year = Convert.ToInt32(Console.ReadLine());

                //Instanciar la clase Date.cs
                Date dateObject = new Date(year, month, day);
                Console.Write("\n"); //Salto de línea
                Console.WriteLine(dateObject.ToString()); //23/50/23232

                Console.Write("Ingrese Identifiación: ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese nombre completo: ");
                firstName = Console.ReadLine();

                Console.Write("Ingrese apellidos: ");
                lastName = Console.ReadLine();

                Console.Write("Ingrese salario devengado: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Escribe la comisión en porcentaje");
                float commissionPercentage = Convert.ToSingle(Console.ReadLine());
                commissionPercentage = commissionPercentage / 100;

                Console.WriteLine("ingrese sus ventas ");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Type your value per hour: ");
                decimal hourValue = Convert.ToDecimal(Console.ReadLine());

                Employee commissionEmployee = new CommissionEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    CommissionPercentage = commissionPercentage,
                    Sales = sales
                  
                };


                //Esta es la forma de crear objetos a partir de una clase concreta
                SalaryEmployee salaryEmployee = new SalaryEmployee()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = dateObject,
                    HiringDate = dateObject,
                    IsActive = true,
                    Salary = salary
                };

                Console.Clear();
                Console.WriteLine(salaryEmployee);

                //salaryEmployee.Id = 123;
                //salaryEmployee.FirstName = "Juan";
                //salaryEmployee.LastName = "Gómez";
                //salaryEmployee.BirthDate = dateObject;
                //salaryEmployee.HiringDate = dateObject;
                //salaryEmployee.IsActive = true;
            }
            catch (Exception ex)
            {
                Console.Write("\n");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
