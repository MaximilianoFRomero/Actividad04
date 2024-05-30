using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad04.Model
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal HourlySalary { get; set; }

        public Employee(string name, string position, decimal hourlySalary) 
        {
            this.Name = name;
            this.Position = position;
            this.HourlySalary = hourlySalary;
        }
    }
}
