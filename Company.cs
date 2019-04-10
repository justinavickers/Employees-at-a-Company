using System;
using System.Collections.Generic;

namespace classes
{
  public class Company
  {

    public List<Employee> Employees {get;}
    public DateTime DateFounded = DateTime.Now;
    public string CompanyName;
    public Company(DateTime dateFounded, string companyName)
    {
        DateFounded = dateFounded;
        CompanyName = companyName;
        Employees = new List<Employee>();
    }
    public void ListAllEmployees()
    {
      foreach (Employee employee in Employees)
      {
        // Console.WriteLine($"{employee.FirstName} {employee.LastName}");
      }
    }
    public void addEmployee(Employee employee)
    {
      Employees.Add(employee);
    }

  }
}