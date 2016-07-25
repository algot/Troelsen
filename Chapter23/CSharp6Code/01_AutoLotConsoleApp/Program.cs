using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_AutoLotConsoleApp.EF;

namespace _01_AutoLotConsoleApp
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Fun with ADO.NET EF ****\n");
      int carId = AddNewRecord();
      Console.WriteLine(carId);
      //PrintAllInventory();
      //FunWithLinqQueries();
      UpdateRecord(carId);
      RemoveRecordUsingEntityState(carId);
    }

    private static void PrintAllInventory()
    {
      using (var context = new AutoLotEntities())
      {
        //foreach (Car car in context.Cars)
        //{
        //  Console.WriteLine(car);
        //}
        //foreach (Car car in context.Cars.SqlQuery("Select CarId, Make, Color, PetName as CarNickName from Inventory " +
        //                                          "where Make=@p0", "BMW"))
        //{
        //  Console.WriteLine(car);
        //}
        foreach (Car car in context.Cars.Where(c => c.Make == "BMW"))
        {
          Console.WriteLine(car);
        }
      }
    }

    private static int AddNewRecord()
    {
      // Добавить запись в таблицу Inventory базы AutoLot
      using (var context = new AutoLotEntities())
      {
        try
        {
          var car = new Car { Make = "Yugo", Color = "Brown", CarNickName = "Brownie" };
          context.Cars.Add(car);
          context.SaveChanges();

          return car.CarId;
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.InnerException.Message);
          return 0;
        }
      }
    }

    private static void FunWithLinqQueries()
    {
      using (var context = new AutoLotEntities())
      {
        var allData = context.Cars.ToArray();
        // Get a projection of new data
        var colorsMakes = from item in allData select new { item.Color, item.Make };
        foreach (var item in colorsMakes)
        {
          Console.WriteLine(item);
        }

        // Get only items where Color == "Black"
        var blackCars = from item in allData where item.Color == "Black" select item;
        foreach (var item in blackCars)
        {
          Console.WriteLine(item);
        }
      }
    }

    private static void RemoveRecord(int carId)
    {
      // Find a car to delete by primary key
      using (var context = new AutoLotEntities())
      {
        Car carToDelete = context.Cars.Find(carId);
        if (carToDelete != null)
        {
          context.Cars.Remove(carToDelete);
          context.SaveChanges();
        }
      }
    }

    private static void RemoveRecordUsingEntityState(int carId)
    {
      using (var context = new AutoLotEntities())
      {
        Car carToDelete = new Car { CarId = carId };
        context.Entry(carToDelete).State = EntityState.Deleted;
        try
        {
          context.SaveChanges();
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex);
        }
      }
    }

    private static void UpdateRecord(int carId)
    {
      using (var context = new AutoLotEntities())
      {
        Car carToUpdate = context.Cars.Find(carId);
        if (carToUpdate != null)
        {
          Console.WriteLine(context.Entry(carToUpdate).State);
          carToUpdate.Color = "Blue";
          Console.WriteLine(context.Entry(carToUpdate).State);
          context.SaveChanges();
        }

      }
    }
  }
}
