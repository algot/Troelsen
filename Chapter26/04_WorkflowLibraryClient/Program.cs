using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_CheckInventoryWorkflowLib;

namespace _04_WorkflowLibraryClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Inventory Look Up *****");

      // Получить предпочтения пользователя
      Console.Write("Enter Color: ");
      string color = Console.ReadLine();
      Console.Write("Enter Make: ");
      string make = Console.ReadLine();

      // Упаковать данные для рабочего потока
      var wfArgs = new Dictionary<string, object>
      {
        {"RequestedColor", color},
        {"RequestedMake", make}
      };
      try
      {
        // Отправить данные рабочему потоку
        WorkflowInvoker.Invoke(new CheckInventory(), wfArgs);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}