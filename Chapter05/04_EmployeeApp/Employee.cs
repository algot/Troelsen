namespace Employees
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public partial class Employee
  {
    // Свойства
    public string Name
    {
      get { return empName; }
      set
      {
        if (value.Length > 15)
        {
          Console.WriteLine("\nError!\nName \"{0}\" is incorrect. Name should be less than 16 characters!\n", value);
        }
        else
          empName = value;
      }
    }
    public int ID
    {
      get { return empId; }
      set { empId = value; }
    }
    public float Pay
    {
      get { return currPay; }
      set { currPay = value; }
    }
    public int Age
    {
      get { return empAge; }
      set { empAge = value; }
    }
    public string SocialSecurityNumber
    {
      get { return empSSN; }
      set { empSSN = value; }
    }
    public static string CompanyName
    {
      get { return companyName; }
      set { companyName = value; }
    }

    // Методы.
    public void GiveBonus(float amount)
    {
      Pay += amount;
    }
    public void DisplayStats()
    {
      Console.WriteLine("Name: {0}", Name);
      Console.WriteLine("Age: {0}", Age);
      Console.WriteLine("Id: {0}", ID);
      Console.WriteLine("Pay: {0}", Pay);
      Console.WriteLine("SSN: {0}", SocialSecurityNumber);
      Console.WriteLine("Company: {0}", CompanyName);
    }
    /*    // Метод доступа (метод Get)
        public string GetName()
        {
          return empName;
        }
        // Метод изменения (метод Set)
        public void SetName(string name)
        {
          // Проверка значения перед присваиванием.
          if (name.Length > 15)
          {
            Console.WriteLine("\nError!\nName \"{0}\" is incorrect. Name should be less than 16 characters!", name);
          }
          else
            empName = name;
        }*/
  }
}
