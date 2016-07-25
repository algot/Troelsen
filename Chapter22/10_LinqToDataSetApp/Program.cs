using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using AutoLotDAL.AutoLotDataSetTableAdapters;

namespace _10_LinqToDataSetApp
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** LINQ over DataSet *****\n");
      // Получить строго типизированный объект DataTable, 
      // содержащий текущие данные таблицы Inventory из базы данных AutoLot
      AutoLotDataSet dal = new AutoLotDataSet();
      InventoryTableAdapter da = new InventoryTableAdapter();
      AutoLotDataSet.InventoryDataTable data = da.GetData();

      PrintAllCarIds(data);
      ShowBlackCars(data);

    }

    private static void PrintAllCarIds(DataTable data)
    {
      // Получить перечислимую версию DataTable
      EnumerableRowCollection enumData = data.AsEnumerable();
      // Вывести значения идентификаторов автомобилей
      foreach (DataRow row in enumData)
      {
        Console.WriteLine("Car Id = {0}", row["CarId"]);
      }
      Console.WriteLine();
    }

    private static void ShowBlackCars(DataTable data)
    {
      var cars = from car in data.AsEnumerable()
                 where car.Field<string>("Color") == "Black"
                 select new
                 {
                   Id = car.Field<int>("CarId"),
                   Make = car.Field<string>("Make")
                 };

      Console.WriteLine("Here are the black cars we have in stock:");
      foreach (var item in cars)
      {
        Console.WriteLine("-> CarId = {0} is {1}", item.Id, item.Make);
      }
    }

    private static void BuildDataTableFromQuery(DataTable data)
    {
      var cars = from car in data.AsEnumerable()
                 where car.Field<int>("CarId") > 5
                 select car;
      // Использовать этот набор для построения нового объекта DataTable
      DataTable newTable = cars.CopyToDataTable();

      // Вывести содержимое DataTable
      for (int curRow = 0; curRow < newTable.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < newTable.Columns.Count; curCol++)
        {
          Console.Write(newTable.Rows[curRow][curCol].ToString().Trim() + "\t");
        }
        Console.WriteLine();
      }
    }
  }
}
