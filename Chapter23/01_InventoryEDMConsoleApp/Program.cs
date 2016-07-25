using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InventoryEDMConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with ADO.NET EF *****\n");
      AddNewRecord();
      PrintAllInventory();
    }

    private static void AddNewRecord()
    {
      // Добавить запись в таблицу Inventory базы данных AutoLot
      using (AutoLotEntities context = new AutoLotEntities())
      {
        try
        {
          // Добавить тестовые данные
          context.Cars.Add(new Car() {CarId = 2222, Make = "Yugo", Color = "Brown"});
          context.SaveChanges();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.InnerException.Message);
        }
      }
    }

    private static void PrintAllInventory()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        foreach (Car c in context.Cars)
        {
          Console.WriteLine(c);
        }
      }
    }

    private static void RemoveRecord()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        var carToDelete = (from c in context.Cars where c.CarId == 2222 select c).FirstOrDefault();
        if (carToDelete != null)
        {
          context.Entry(carToDelete).State = EntityState.Deleted;
          context.SaveChanges();
        }
      } 
    }
  }
}
