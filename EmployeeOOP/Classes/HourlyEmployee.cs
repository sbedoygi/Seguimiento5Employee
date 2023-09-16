using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {

        public float Hours { get; set; }
        public decimal HourValue { get; set; }





        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Hours.....................{Hours:N2}\n\t" +
                $"Value for hour............{HourValue:C2}\n\t" +
                $"Value to Pay..............{GetValueToPay():C2}";
        }




    }
}
