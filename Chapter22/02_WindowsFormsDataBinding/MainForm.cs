using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_WindowsFormsDataBinding
{
  public partial class MainForm : Form
  {
    private List<Car> listCars = null;
    private DataTable inventoryTable = new DataTable();

    public MainForm()
    {
      InitializeComponent();

      listCars = new List<Car>
      {
        new Car {Id = 100, PetName = "Chucky", Make = "BMW", Color = "Green"},
        new Car {Id = 101, PetName = "Tiny", Make = "Yugo", Color = "White"},
        new Car {Id = 102, PetName = "Ami", Make = "Jeep", Color = "Tan"},
        new Car {Id = 103, PetName = "Pain Inducer", Make = "Caravan", Color = "Pink"},
        new Car {Id = 104, PetName = "Fred", Make = "BMW", Color = "Green"},
        new Car {Id = 105, PetName = "Sidd", Make = "BMW", Color = "Black"},
        new Car {Id = 106, PetName = "Mel", Make = "Firebird", Color = "Red"},
        new Car {Id = 107, PetName = "Sarah", Make = "Colt", Color = "Black"},
      };
      CreateDataTable();
    }

    private void CreateDataTable()
    {
      // Создать схему таблицы
      DataColumn carIdColumn = new DataColumn("Id", typeof (int));
      DataColumn carMakeColumn = new DataColumn("Make", typeof (string));
      DataColumn carColorColumn = new DataColumn("Color", typeof (string));
      DataColumn carPetNameColumn = new DataColumn("PetName", typeof (string));
      carPetNameColumn.Caption = "Pet Name";
      inventoryTable.Columns.AddRange(new[] {carIdColumn, carMakeColumn, carColorColumn, carPetNameColumn});
      // Пройти по List<> для создания строк
      foreach (Car car in listCars)
      {
        DataRow newRow = inventoryTable.NewRow();
        newRow["Id"] = car.Id;
        newRow["Make"] = car.Make;
        newRow["Color"] = car.Color;
        newRow["PetName"] = car.PetName;
        inventoryTable.Rows.Add(newRow);
      }
      // Привязать DataTable к carInventoryGridView
      carInventoryGridView.DataSource = inventoryTable;
    }

    private void btnRemoveRow_Click(object sender, EventArgs e)
    {
      try
      {
        // Найти строку для удаления
        DataRow[] rowToDelete = inventoryTable.Select(
          string.Format("Id={0}", int.Parse(txtRowToRemove.Text)));

        rowToDelete[0].Delete();
        inventoryTable.AcceptChanges();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnDisplayMakes_Click(object sender, EventArgs e)
    {
      // Построить фильтр на основе пользовательского ввода
      string filterStr = string.Format("Make= '{0}'", txtMakeToView.Text);
      // Найти все строки, удовлетворяющие фильтру
      DataRow[] makes = inventoryTable.Select(filterStr);
      if (makes.Length == 0)
      {
        MessageBox.Show("Sorry, no cars...", "Selection error!");
      }
      else
      {
        string strMake = string.Empty;
        for (int i = 0; i < makes.Length; i++)
        {
          strMake += makes[i]["PetName"] + "\n";
        }

        MessageBox.Show(strMake, string.Format("We have {0}s named:", txtMakeToView.Text));
      }
    }

    private void btnChangeMake_Click(object sender, EventArgs e)
    {
      // Получить производителя для изменения
      string makeToChange = txtChangeMake.Text;

      if (makeToChange.Length > 0 &&
          DialogResult.Yes ==
          MessageBox.Show(string.Format("Are you sure?? {0}s are much nicer than Yugos!", makeToChange),
            "Please Confirm!", MessageBoxButtons.YesNo))
      {
        // Построить фильтр.
        string filterStr = string.Format("Make='{0}'", makeToChange);
        string strMake = string.Empty;

        // Найти все строки, удовлетворяющие фильтру
        DataRow[] makes = inventoryTable.Select(filterStr);

        // Заменить все производители
        for (int i = 0; i < makes.Length; i++)
        {
          makes[i]["Make"] = "Yugo";
        }
      }
    }
  }
}