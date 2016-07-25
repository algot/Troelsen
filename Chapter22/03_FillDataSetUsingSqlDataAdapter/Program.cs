using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FillDataSetUsingSqlDataAdapter
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Data Adapters *****\n");
      // Жестко закодированная строка соединения
      string cnStr = "Integrated Security = SSPI;Initial Catalog=AutoLot;" +
                     @"Data Source=.\SQLEXPRESS";
      // Объект DataSet создается вызывающим процессом
      DataSet ds = new DataSet("AutoLot");
      // Указать адаптеру команду и строку соединения
      SqlDataAdapter dAdapt = new SqlDataAdapter("Select * From Inventory", cnStr);
      // Отобразить имена столбцов базы данных на дружественные имена
      DataTableMapping custMap = dAdapt.TableMappings.Add("Inventory", "Current Inventory");
      custMap.ColumnMappings.Add("CarId", "Car Id");
      custMap.ColumnMappings.Add("PetName", "Name of Car");
      // Заполнить DataSet новой таблицей по имени Inventory
      dAdapt.Fill(ds, "Inventory");
      // Отобразить DataSet
      PrintDataSet(ds);
    }

    private static void PrintDataSet(DataSet ds)
    {
      // Вывести имя DataSet и любые расширенные свойства
      Console.WriteLine("DataSet is named: {0}", ds.DataSetName);
      foreach (DictionaryEntry de in ds.ExtendedProperties)
      {
        Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
      }
      Console.WriteLine();
      // Вывести каждую таблицу
      foreach (DataTable dt in ds.Tables)
      {
        Console.WriteLine("=> {0} Table:", dt.TableName);
        // Вывести имена столбцов
        for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
        {
          Console.Write(dt.Columns[curCol].ColumnName.Trim() + "\t");
        }
        Console.WriteLine("\n----------------------------------");

        PrintTable(dt);
      }
    }
    private static void PrintTable(DataTable dt)
    {
      // Получить объект DataTableReader
      DataTableReader dtReader = dt.CreateDataReader();
      // DataTableReader работает в точности как DataReader
      while (dtReader.Read())
      {
        for (int i = 0; i < dtReader.FieldCount; i++)
        {
          Console.Write("{0}\t", dtReader.GetValue(i).ToString());
        }
        Console.WriteLine();
      }
      dtReader.Close();
    }
  }
}
