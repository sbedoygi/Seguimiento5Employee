using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class BaseCommissionEmployee : CommissionEmployee
    {


        public decimal Base { get; set; }


        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Base......................{Base:C2}\n\t" +
                $"Total Value to pay........{GetValueToPay():C2}";
        }


    }
}

