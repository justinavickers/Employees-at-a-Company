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
      Company WarnersCompany = new Company(DateTime.Now, "Warner's Company" );
      Company DooDrop = new Company(DateTime.Now, "DooDrop");
      Company CrazyEight = new Company(DateTime.Now, "Crazy Eight");
      List<Company> CompanyList = new List<Company>();
      WarnersCompany.addEmployee(FredArmisen);
      CrazyEight.addEmployee(SteveJobs);
      DooDrop.addEmployee(DeannaSienna);

      CompanyList.Add(WarnersCompany);
      CompanyList.Add(DooDrop);
      CompanyList.Add(CrazyEight);

    foreach (Company currentCompany in CompanyList){Console.WriteLine($@"
Company Name{currentCompany.CompanyName}
Company Date{currentCompany.DateFounded}
        ");
       foreach (Employee employee in currentCompany.Employees){Console.WriteLine($@"
My name is {employee.FirstName} {employee.LastName}.
My job title is {employee.JobTitle}.");

       }
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
