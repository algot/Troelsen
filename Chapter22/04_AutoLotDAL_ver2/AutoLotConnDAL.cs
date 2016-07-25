using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotDisconnectedLayer
{
  public class InventoryDAL
  {
    private SqlConnection sqlCn = null;

    public void OpenConnection(string connectionString)
    {
      sqlCn = new SqlConnection();
      sqlCn.ConnectionString = connectionString;
      sqlCn.Open();
    }
    public void CloseConnection()
    {
      sqlCn.Close();
    }

    public void InsertAuto(int id, string color, string make, string petName)
    {
      string sql = "Insert Into Inventory(CarId, Make, Color, PetName) Values(@CarId, @Make, @Color, @Petname)";

      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        SqlParameter param = new SqlParameter
        {
          ParameterName = "@CarId",
          Value = id,
          SqlDbType = SqlDbType.Int
        };
        cmd.Parameters.Add(param);

        param = new SqlParameter
        {
          ParameterName = "@Make",
          Value = make,
          SqlDbType = SqlDbType.Char,
          Size = 10
        };
        cmd.Parameters.Add(param);

        param = new SqlParameter
        {
          ParameterName = "@Color",
          Value = color,
          SqlDbType = SqlDbType.Char,
          Size = 10
        };
        cmd.Parameters.Add(param);

        param = new SqlParameter
        {
          ParameterName = "@PetName",
          Value = petName,
          SqlDbType = SqlDbType.Char,
          Size = 10
        };
        cmd.Parameters.Add(param);

        cmd.ExecuteNonQuery();
      }
    }
    public void InsertAuto(NewCar car)
    {
      string sql = string.Format("Insert Into Inventory" +
                                 "(CarId, Make, Color, PetName) Values" +
                                 "('{0}', '{1}', '{2}', '{3}')", car.CarId, car.Make, car.Color, car.PetName);
      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        cmd.ExecuteNonQuery();
      }
    }

    public void DeleteCar(int id)
    {
      string sql = string.Format("Delete from Inventory where CarId = '{0}'", id);
      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        try
        {
          cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
          Exception error = new Exception("Sorry! That car is on order!", ex);
          throw error;
        }
      }
    }

    public void UpdateCarPetName(int id, string newPetName)
    {
      string sql = string.Format("Update Inventory Set PetName = '{0} Where CarId = '{1}'",
        newPetName, id);

      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        cmd.ExecuteNonQuery();
      }
    }

    public List<NewCar> GetAllInventoryAsList()
    {
      List<NewCar> inv = new List<NewCar>();

      string sql = "Select * From Inventory";
      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
          inv.Add(new NewCar
          {
            CarId = (int)dr["CarId"],
            Color = (string)dr["Color"],
            Make = (string)dr["Make"],
            PetName = (string)dr["PetName"]
          });
        }
        dr.Close();
      }
      return inv;
    }

    public DataTable GetAllInventoryAsDataTable()
    {
      DataTable inv = new DataTable();

      string sql = "Select * From Inventory";

      using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
      {
        SqlDataReader dr = cmd.ExecuteReader();
        inv.Load(dr);
        dr.Close();
      }
      return inv;
    }

    public string LookUpPetName(int carId)
    {
      string carPetName = string.Empty;

      using (SqlCommand cmd = new SqlCommand("GetPetName", this.sqlCn))
      {
        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter param = new SqlParameter
        {
          ParameterName = "@carId",
          SqlDbType = SqlDbType.Int,
          Value = carId,
          Direction = ParameterDirection.Input
        };
        cmd.Parameters.Add(param);

        param = new SqlParameter
        {
          ParameterName = "@petName",
          SqlDbType = SqlDbType.Char,
          Size = 10,
          Direction = ParameterDirection.Output
        };
        cmd.Parameters.Add(param);

        cmd.ExecuteNonQuery();

        carPetName = (string) cmd.Parameters["@petName"].Value;
      }
      return carPetName;
    }

    public void ProcessCreditRisk(bool throwEx, int custId)
    {
      string fName;
      string lName;

      SqlCommand cmdSelect = new SqlCommand(
        string.Format("Select * from Customers where CustId = {0}", custId), sqlCn);
      using (SqlDataReader dr = cmdSelect.ExecuteReader())
      {
        if (dr.HasRows)
        {
          dr.Read();
          fName = (string) dr["FirstName"];
          lName = (string) dr["LastName"];
        }
        else
        {
          return;
        }
      }
      SqlCommand cmdRemove = new SqlCommand(
        string.Format("Delete from Customers where CustId= {0}", custId), sqlCn);
      SqlCommand cmdInsert = new SqlCommand(
        string.Format("Insert into CreditRisks" +
                      "(CustId, FirstName, LastName) Values" +
                      "({0}, '{1}', '{2}')", custId, fName, lName), sqlCn);

      SqlTransaction tx = null;
      try
      {
        tx = sqlCn.BeginTransaction();

        cmdInsert.Transaction = tx;
        cmdRemove.Transaction = tx;

        cmdInsert.ExecuteNonQuery();
        cmdRemove.ExecuteNonQuery();

        // Имитировать ошибку
        if (throwEx)
        {
          throw new Exception("Sorry! Database error! Tx failed...");
        }
        // Зафиксировать транзакцию
        tx.Commit();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        tx.Rollback();
      }
    }
  }

  public class NewCar
  {
    public int CarId { get; set; }
    public string Color { get; set; }
    public string Make { get; set; }
    public string PetName { get; set; }
  }
}
