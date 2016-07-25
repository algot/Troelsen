using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AutoLotDataReader
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Data Readers *****\n");

      SqlConnectionStringBuilder cnStrBuilder = new SqlConnectionStringBuilder
      {
        InitialCatalog = "AutoLot",
        DataSource = @".\SQLEXPRESS",
        ConnectTimeout = 30,
        IntegratedSecurity = true
      };

      // Создать и открыть подключение
      using (SqlConnection cn = new SqlConnection())
      {
        cn.ConnectionString = cnStrBuilder.ConnectionString;
        cn.Open();
        ShowConnectionStatus(cn);

        // Создать объект комманды SQL
        const string strSQL = "Select * from Inventory;Select * from Customers";
        SqlCommand myCommand = new SqlCommand(strSQL, cn);

        SqlCommand testCommand = new SqlCommand
        {
          Connection = cn,
          CommandText = strSQL
        };

        // Получить объект чтения данных с помощью ExecuteReader()
        using (SqlDataReader myDataReader = myCommand.ExecuteReader())
        {
          // Организовать цикл по результатам

          do
          {
            while (myDataReader.Read())
            {
              Console.WriteLine("***** Record *****");
              for (int i = 0; i < myDataReader.FieldCount; i++)
              {
                Console.WriteLine("{0} = {1} ",
                  myDataReader.GetName(i),
                  myDataReader.GetValue(i));
              }
              Console.WriteLine();
            }
          } while (myDataReader.NextResult());
        }
      }
    }

    private static void ShowConnectionStatus(SqlConnection cn)
    {
      Console.WriteLine("***** Info about connection *****");
      Console.WriteLine("Database location: {0}", cn.DataSource);
      Console.WriteLine("Database name: {0}", cn.Database);
      Console.WriteLine("Timeout: {0}", cn.ConnectionTimeout);
      Console.WriteLine("Connection state: {0}\n", cn.State.ToString());
    }
  }
}