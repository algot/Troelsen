using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  public partial class Employee
  {
    // Поля данных.
    protected string empName;
    protected int empId;
    protected float currPay;
    protected int empAge;
    protected string empSSN;
    protected static string companyName;

    // Конструкторы.
    static Employee()
    {
      companyName = "My Company Inc.";
    }
    public Employee() { }
    public Employee(string name)
      : this(name, 0, 0, 0, "") { }
    public Employee(string name, int id, float pay)
      : this(name, 0, id, pay, "") { }

    public Employee(string name, int age, int id, float pay, string ssn)
    {
      Name = name;
      ID = id;
      Age = age;
      Pay = pay;
      // SocialSecurityNumber = ssn;
      CompanyName = companyName;
    }
  }
}
