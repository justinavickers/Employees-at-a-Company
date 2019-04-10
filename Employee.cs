using System;
using System.Collections.Generic;

namespace classes
{

public class Employee
  {
    private string _firstName;
    private string _lastName;
    private string _jobTitle;
    private DateTime _startDate;
    public string FirstName
    {
      get
      {
        return _firstName;
      }
      set {
        _firstName = value;
      }
    }
    public string LastName
    {
      get
      {
        return _lastName;
      }
      set {
        _lastName = value;
      }
    }

    public string JobTitle
    {
      get
      {
        return _jobTitle;
      }
      set {
        _jobTitle = value;
      }
    }

    public DateTime StartDate
    {
      get
      {
        return _startDate;
      }
      set {
        _startDate = value;
      }
    }

    public void Hire()
    {
      _startDate = DateTime.Now;
    }
  }
}