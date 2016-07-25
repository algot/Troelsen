using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConnectedLayer;

namespace _05_AutoLotCUIClient
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** The AutoLot Console UI *****\n");
      // Получить сторку соединения из App.config
      string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      bool userDone = false;
      string userCommand = string.Empty;

      // Создать объект InventoryDAL
      InventoryDAL invDAL = new InventoryDAL();
      invDAL.OpenConnection(cnStr);

      // Продолжать запрашивать у юзера ввод вплоть до получения команды Q
      try
      {
        ShowInstructions();
        do
        {
          Console.WriteLine("\nPlease enter your command: ");
          userCommand = Console.ReadLine();
          Console.WriteLine();

          switch (userCommand.ToUpper())
          {
            case "I":
              InsertNewCar(invDAL);
              break;
            case "U":
              UpdateCarPetName(invDAL);
              break;
            case "D":
              DeleteCar(invDAL);
              break;
            case "L":
              ListInventory(invDAL);
              break;
            case "S":
              ShowInstructions();
              break;
            case "P":
              LookUpPetName(invDAL);
              break;
            case "Q":
              userDone = true;
              break;
            default:
              Console.WriteLine("Bad data! Try again!");
              break;
          }
        } while (!userDone);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        invDAL.CloseConnection();
      }
    }

    private static void ShowInstructions()
    {
      Console.WriteLine("I: Insert a new car.");
      Console.WriteLine("U: Updates an existing car.");
      Console.WriteLine("D: Deletes an existing car.");
      Console.WriteLine("L: Lists current inventory.");
      Console.WriteLine("S: Shows these instructions.");
      Console.WriteLine("P: Looks up pet name.");
      Console.WriteLine("Q: Quits program.");
    }

    private static void ListInventory(InventoryDAL invDal)
    {
      DataTable dt = invDal.GetAllInventoryAsDataTable();
      DisplayTable(dt);
    }

    private static void DeleteCar(InventoryDAL invDal)
    {
      // Получить идентификатор удаляемого автомобиля
      Console.Write("Enter ID of Car to delete");
      int id = int.Parse(Console.ReadLine());

      try
      {
        invDal.DeleteCar(id);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private static void InsertNewCar(InventoryDAL invDal)
    {
      Console.Write("Enter Car Id:");
      var newCarId = int.Parse(Console.ReadLine());
      Console.Write("Enter Car Color: ");
      var newCarColor = Console.ReadLine();
      Console.Write("Enter Car Make: ");
      var newCarMake = Console.ReadLine();
      Console.Write("Enter Pet Name: ");
      var newCarPetName = Console.ReadLine();

      invDal.InsertAuto(newCarId, newCarColor, newCarMake, newCarPetName);
    }

    private static void UpdateCarPetName(InventoryDAL invDal)
    {
      Console.Write("Enter Car Id: ");
      var carId = int.Parse(Console.ReadLine());
      Console.Write("Enter New Pet Name: ");
      var newCarPetName = Console.ReadLine();

      invDal.UpdateCarPetName(carId, newCarPetName);
    }

    private static void LookUpPetName(InventoryDAL invDal)
    {
      Console.Write("Enter Id of Car to look up: ");
      int id = int.Parse(Console.ReadLine());
      Console.WriteLine("Petname of {0} is {1}.",
        id, invDal.LookUpPetName(id).TrimEnd());
    }

    private static void DisplayTable(DataTable dt)
    {
      // Вывести имена столбцов
      for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
      {
        Console.Write(dt.Columns[curCol].ColumnName + "\t");
      }
      Console.WriteLine("\n------------------------------");
      // Вывести содержимое
      for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
        }
        Console.WriteLine();
      }
    }
  }
}
