using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConnectedLayer;

namespace _06_AdoNetTransaction
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Simple Transaction Example *****\n");

      bool throwEx = true;
      string userAnswer = string.Empty;

      Console.Write("Do you want to throw an exception (Y or N): ");
      userAnswer = Console.ReadLine();
      if (userAnswer.ToLower() == "n")
      {
        throwEx = false;
      }

      InventoryDAL dal = new InventoryDAL();
      dal.OpenConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=SSPI;" +
        "Initial Catalog=AutoLot");

      dal.ProcessCreditRisk(throwEx, 333);
      Console.WriteLine("Chech CreditRisk table for results");
    }
  }
}
