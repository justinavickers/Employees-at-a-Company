using System;
using System.Collections.Generic;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee DeannaSienna = new Employee()
      {
        FirstName = "Deanna",
        LastName = "Sienna",
        JobTitle = "Junior Developer",
      };

      Employee SteveJobs = new Employee()
      {
        FirstName = "Steve",
        LastName = "Jobs",
        JobTitle = "Developer"
      };

      Employee FredArmisen = new Employee()
      {
        FirstName = "Fred",
        LastName = "Armisen",
        JobTitle = "Actor"
      };

      Company CrazyEight = new Company(DateTime.Now, "Crazy Eight");
      CrazyEight.addEmployee(FredArmisen);
      CrazyEight.addEmployee(SteveJobs);
      CrazyEight.addEmployee(DeannaSienna);

    foreach (Employee employee in CrazyEight.Employees)
     {
        Console.WriteLine($@"
        My name is {employee.FirstName} {employee.LastName}.
        My job title is {employee.JobTitle}.
        ");
    }



      // Create three employees

      // Assign the employees to the company
      //   foreach (Employee Employees in Company)
      //   {
      //     Console.WriteLine($@"{Employee.Company.Employees}");
      //   }
      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
    }
  }
}
