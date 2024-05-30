using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad04.Model
{
    class Report
    {
        public string email {  get; set; }

        private CalculatePayroll payroll;

        public Report(string email) 
        {
            this.email = email;
            this.payroll = new CalculatePayroll();
        }

        public string PayrollReport(Employee employee, int hoursWorked) 
        {
            return $"Email: {email}. Estimado {employee.Name}, a continuacion le adjuntamos su reporte\nde pago.\nHoras trabajadas: {hoursWorked}, Pago {payroll.Calculate(hoursWorked, employee)}";
        }
    }
}
