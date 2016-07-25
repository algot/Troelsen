using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
  class Program
  {
    static void GivePromotion(Employee emp)
    {
      Console.WriteLine("{0} was promoted!", emp);
      if (emp is SalesPerson)
      {
        Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
      }
      if (emp is Manager)
      {
        Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOption);
      }
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      Console.WriteLine("***** Employee class hierarchy *****\n");

      Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-22-2323", 9000);
      double cost = chucky.GetBenefitCost();
      chucky.GiveBonus(300);
      chucky.DisplayStats();
      Console.WriteLine();

      SalesPerson fran = new SalesPerson("Frank", 43, 93, 3000, "333-11-0000", 31);
      fran.GiveBonus(200);
      fran.DisplayStats();
      Console.WriteLine();

      object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
      Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
      SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);

      GivePromotion((Manager)frank);
      GivePromotion(moonUnit);
      GivePromotion(jill);
    }
  }
}
