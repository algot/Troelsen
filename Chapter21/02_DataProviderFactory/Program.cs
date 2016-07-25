using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataProviderFactory
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Data Provider Factories *****\n");
      
      // Получить строку соединения и поставщика из файла *.config
      string dp = ConfigurationManager.AppSettings["provider"];
      string cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      // Получить фабрику поставщиков
      DbProviderFactory df = DbProviderFactories.GetFactory(dp);
      // Получить объект подключения
      using (DbConnection cn = df.CreateConnection())
      {
        Console.WriteLine("Your connection object is a: {0}", cn.GetType().Name);
        cn.ConnectionString = cnStr;
        cn.Open();

        // Создать объект комманды
        DbCommand cmd = df.CreateCommand();
        Console.WriteLine("Your command object is a: {0}", cmd.GetType().Name);
        cmd.Connection = cn;
        cmd.CommandText = "Select * From Inventory";

        // Вывести данные с помощью объекта чтения данных
        using (DbDataReader dr = cmd.ExecuteReader())
        {
          Console.WriteLine("Your data reader object is a: {0}", dr.GetType().Name);
          Console.WriteLine("\n***** Current Inventory *****");
          while (dr.Read())
          {
            Console.WriteLine("-> Car #{0} is a {1}.", dr["CarId"], dr["Make"]);
          }
        }
      }
    }
  }
}