using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with encapsulation. *****");
      Employee emp1 = new Employee("Marvin", 456, 30000);
      emp1.GiveBonus(1000);
      emp1.DisplayStats();
      emp1.Name = "Marv";
      Console.WriteLine("Employee is named {0}", emp1.Name);

      Employee emp2 = new Employee("Joe");
      emp2.Name = "Blalalalalalalalalaalalalala";

      Employee joe= new Employee("Joe");
      joe.Age++;
      joe.DisplayStats();


    }
  }
}
