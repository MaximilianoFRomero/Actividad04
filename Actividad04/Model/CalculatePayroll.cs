using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad04.Model
{
    class CalculatePayroll
    {
        public decimal Calculate(int hoursWorked, Employee employee) 
        {
            return hoursWorked * employee.HourlySalary;
        }
    }
}
