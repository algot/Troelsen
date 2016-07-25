using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MyConnectionFactory
{
  internal enum DataProvider { SqlServer, OleDb, Odbc, None }

  public static class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("**** Very Simple Connection Factory *****\n");
      // Прочитать ключ provider
      string dataProviderString = ConfigurationManager.AppSettings["provider"];
      // Преобразовать string в enum
      DataProvider dp = DataProvider.None;
      if (Enum.IsDefined(typeof(DataProvider), dataProviderString))
      {
        dp = (DataProvider) Enum.Parse(typeof (DataProvider), dataProviderString);
      }
      else
      {
        Console.WriteLine("Sorry, no provider exists!");
      }
      
      // Получить конкретное подключение
      IDbConnection myCn = GetConnection(dp);
      if (myCn != null)
      {
        Console.WriteLine("Your connection is a {0}", myCn.GetType().Name);
      }
    }

    static IDbConnection GetConnection(DataProvider dp)
    {
      IDbConnection conn = null;
      switch (dp)
      {
        case DataProvider.SqlServer:
          conn = new SqlConnection();
          break;
        case DataProvider.Odbc:
          conn = new OdbcConnection();
          break;
      }

      return conn;
    }
  }
}
