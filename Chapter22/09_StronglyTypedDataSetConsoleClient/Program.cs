using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;
using AutoLotDAL.AutoLotDataSetTableAdapters;

namespace _09_StronglyTypedDataSetConsoleClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Strongly Typed DataSets *****\n");

      AutoLotDataSet.InventoryDataTable table = new AutoLotDataSet.InventoryDataTable();
      InventoryTableAdapter dAdapt = new InventoryTableAdapter();

      dAdapt.Fill(table);
      PrintInventory(table);

      AddRecords(table, dAdapt);
      table.Clear();
      dAdapt.Fill(table);
      PrintInventory(table);
    }

    private static void PrintInventory(AutoLotDataSet.InventoryDataTable dt)
    {
      // Вывести имена столбцов
      for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
      {
        Console.Write(dt.Columns[curCol].ColumnName + "\t");
      }
      Console.WriteLine("\n------------------------------------");
      // Вывести данные
      for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
      {
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Rows[curRow][curCol].ToString() + "\t");
        }
        Console.WriteLine();
      }
    }

    private static void AddRecords(AutoLotDataSet.InventoryDataTable tb, InventoryTableAdapter dAdapt)
    {
      try
      {
        // Получить из таблицы строго типизированную строку
        AutoLotDataSet.InventoryRow newRow = tb.NewInventoryRow();
        
        // Заполнить строку данными
        newRow.CarId = 999;
        newRow.Color = "Purple";
        newRow.Make = "BMW";
        newRow.PetName = "Saku";
        // Вставить строку
        tb.AddInventoryRow(newRow);
        // Добавить еще 1 строку, используя перегруженный метод добавления
        tb.AddInventoryRow(888, "Yugo", "Green", "Zippy");
        // Обновить базу
        dAdapt.Update(tb);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
