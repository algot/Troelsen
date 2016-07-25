using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _01_SimpleDataSet
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with DataSets *****\n");
      // Создать объект DataSet и добавить несколько свойств
      DataSet carsInventoryDS = new DataSet("Car Inventory");

      carsInventoryDS.ExtendedProperties["TimeStamp"] = DateTime.Now;
      carsInventoryDS.ExtendedProperties["DataSetId"] = Guid.NewGuid();
      carsInventoryDS.ExtendedProperties["Company"] = "Mikko's Hot Tub Super Store";

      FillDataSet(carsInventoryDS);
      PrintDataSet(carsInventoryDS);
      SaveAndLoadAsXml(carsInventoryDS);
      SaveAndLoadAsBinary(carsInventoryDS);
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

    private static void FillDataSet(DataSet ds)
    {
      // Создать столбцы данных, которые отображаются на реальные столбцы
      // в таблице Inventory из базы AutoLot
      DataColumn carIdColumn = new DataColumn("CarId", typeof(int))
      {
        Caption = "Car Id",
        ReadOnly = true,
        AllowDBNull = false,
        Unique = true,
        AutoIncrement = true,
        AutoIncrementSeed = 0,
        AutoIncrementStep = 1
      };

      DataColumn carMakeColumn = new DataColumn("Make", typeof(string));
      DataColumn carColorColumn = new DataColumn("Color", typeof(string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption = "Pet Name" };

      // Добавить объекты DataColumn в DataTable
      DataTable inventoryTable = new DataTable("Inventory");
      inventoryTable.Columns.AddRange(new DataColumn[] { carIdColumn, carMakeColumn, carColorColumn, carPetNameColumn });

      // Добавить несколько строк в таблицу Inventory
      DataRow carRow = inventoryTable.NewRow();
      carRow["Make"] = "BMW";
      carRow["Color"] = "Black";
      carRow["PetName"] = "Hamlet";
      inventoryTable.Rows.Add(carRow);

      carRow = inventoryTable.NewRow();
      carRow[1] = "Saab";
      carRow[2] = "Red";
      carRow[3] = "Sea Breeze";

      inventoryTable.Rows.Add(carRow);

      // Задать первичный ключ этой таблицы
      inventoryTable.PrimaryKey = new DataColumn[] { inventoryTable.Columns[0] };

      // Добавить таблицу в DataSet
      ds.Tables.Add(inventoryTable);
    }

    private static void ManipulateDataRowState()
    {
      // Создать объект temp типа DataTable для тестирования
      DataTable temp = new DataTable("Temp");
      temp.Columns.Add(new DataColumn("TempColumn", typeof(int)));

      // RowState = Detached (т.е. пока еще не является частью DataTable)
      DataRow row = temp.NewRow();
      Console.WriteLine("After calling NewRow(): {0}", row.RowState);
      // RowState = Added
      temp.Rows.Add(row);
      Console.WriteLine("After calling Rows.Add(): {0}", row.RowState);
      // RowState = Added
      row["TempColumn"] = 10;
      Console.WriteLine("After first assignment: {0}", row.RowState);
      // RowState = Unchanged
      temp.AcceptChanges();
      Console.WriteLine("After calling AcceptChanges(): {0}", row.RowState);
      // RowState = Modified
      row["TempColumn"] = 11;
      Console.WriteLine("After second assignment: {0}", row.RowState);
      // RowState = Deleted
      temp.Rows[0].Delete();
      Console.WriteLine("After calling Delete: {0}", row.RowState);
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

    private static void SaveAndLoadAsXml(DataSet carsInventoryDS)
    {
      // Сохранить DataSet в виде XML
      carsInventoryDS.WriteXml("carsDataSet.xml");
      carsInventoryDS.WriteXmlSchema("carsDataSet.xsd");

      // Очистить DataSet
      carsInventoryDS.Clear();

      // Загрузить DataSet из файла XML
      carsInventoryDS.ReadXml("carsDataSet.xml");
    }

    private static void SaveAndLoadAsBinary(DataSet carsInventoryDS)
    {
      // Установить флаг двоичной сериализации
      carsInventoryDS.RemotingFormat = SerializationFormat.Binary;
      // Сохранить DataSet в двоичном виде
      FileStream fs = new FileStream("BinaryCars.bin", FileMode.Create);
      BinaryFormatter bFormat = new BinaryFormatter();
      bFormat.Serialize(fs, carsInventoryDS);
      fs.Close();

      // Очистить DataSet
      carsInventoryDS.Clear();
      // Загрузить DataSet из двоичного файла
      fs = new FileStream("BinaryCars.bin", FileMode.Open);
      DataSet data = (DataSet) bFormat.Deserialize(fs);
    }
  }
}