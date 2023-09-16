using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
   

        public float CommissionPercentage { get; set; }
        public decimal Sales { get; set; }

        

   
        public override decimal GetValueToPay()
        {

            return Sales 
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Commission Percentage.....{CommissionPercentage:P2}\n\t" +
                $"Sales.....................{Sales:c2}\n\t" +
                $"Value to Pay..............{GetValueToPay():C2}";
        }

       
    }
}

