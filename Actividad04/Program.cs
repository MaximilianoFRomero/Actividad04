using Actividad04.Model;

Employee employee = new Employee("Maxi", "Developer", 2);
Report report = new Report("maxi@papas.com");
Console.WriteLine(report.PayrollReport(employee, 2));