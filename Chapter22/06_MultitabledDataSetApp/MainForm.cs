using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_MultitabledDataSetApp
{
  public partial class MainForm : Form
  {
    // Объект DataSet уровня формы
    private DataSet autoLotDS = new DataSet("AutoLot");
    
    // Использовать построители команд для упрощения конфигурирования адаптеров данных
    private SqlCommandBuilder sqlCBInventory;
    private SqlCommandBuilder sqlCBCustomers;
    private SqlCommandBuilder sqlCBOrders;
    
    // Адаптеры данных для каждой таблицы
    private SqlDataAdapter invTableAdapter;
    private SqlDataAdapter custTableAdapter;
    private SqlDataAdapter ordersTableAdapter;
    
    // Строка соединения уровня формы
    private string cnStr = string.Empty;

    public MainForm()
    {
      InitializeComponent();

      // Получить стороку соединения из *.config
      cnStr = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

      // Создать адаптеры
      invTableAdapter = new SqlDataAdapter("Select * from Inventory", cnStr);
      custTableAdapter = new SqlDataAdapter("Select * from Customers", cnStr);
      ordersTableAdapter = new SqlDataAdapter("Select * from Orders", cnStr);
      
      // Автоматически сгенерировать команды
      sqlCBInventory = new SqlCommandBuilder(invTableAdapter);
      sqlCBCustomers = new SqlCommandBuilder(custTableAdapter);
      sqlCBOrders = new SqlCommandBuilder(ordersTableAdapter);

      // Заполнить таблицы в DataSet
      invTableAdapter.Fill(autoLotDS, "Inventory");
      custTableAdapter.Fill(autoLotDS, "Customers");
      ordersTableAdapter.Fill(autoLotDS, "Orders");

      // Построить отношения между таблицами
      BuildTableRelationship();

      // Привязать к сеткам
      dataGridViewInventory.DataSource = autoLotDS.Tables["Inventory"];
      dataGridViewCustomers.DataSource = autoLotDS.Tables["Customers"];
      dataGridViewOrders.DataSource = autoLotDS.Tables["Orders"];
    }

    private void BuildTableRelationship()
    {
      // Создать объект отношения между данными CustomerOrder
      DataRelation dr = new DataRelation("CustomerOrder",
        autoLotDS.Tables["Customers"].Columns["CustId"],
        autoLotDS.Tables["Orders"].Columns["CustId"]);
      autoLotDS.Relations.Add(dr);
      
      // Создать объект отношения межды данными InvertoryOrder
      dr = new DataRelation("InventoryOrder",
        autoLotDS.Tables["Inventory"].Columns["CarId"],
        autoLotDS.Tables["Orders"].Columns["CarId"]);
      autoLotDS.Relations.Add(dr);


    }

    private void btnUpdateDatabase_Click(object sender, EventArgs e)
    {
      try
      {
        invTableAdapter.Update(autoLotDS, "Inventory");
        custTableAdapter.Update(autoLotDS, "Customers");
        ordersTableAdapter.Update(autoLotDS, "Orders");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnGetOrderInfo_Click(object sender, EventArgs e)
    {
      string strOrderInfo = string.Empty;
      DataRow[] drsCust = null;
      DataRow[] drsOrder = null;

      // Получить идентификатор клиента из текстового поля
      int custId = int.Parse(this.txtCustId.Text);
      // На основе CustId получить подходящую строку из таблицы Customers
      drsCust = autoLotDS.Tables["Customers"].Select(
        string.Format("CustId = {0}", custId));
      strOrderInfo += string.Format("Customer {0}: {1} {2}\n",
        drsCust[0]["CustId"],
        drsCust[0]["FirstName"],
        drsCust[0]["LastName"]);

      // Перейти из таблицы Customers в таблицу Orders
      drsOrder = drsCust[0].GetChildRows(autoLotDS.Relations["CustomerOrder"]);

      // Пройтись по всем заказам клиента
      foreach (DataRow order in drsOrder)
      {
        strOrderInfo += string.Format("----\nOrder Number: {0}\n", order["OrderId"]);
        // Получить автомобиль, на который ссылается этот заказ
        DataRow[] drsInv = order.GetParentRows(autoLotDS.Relations["InventoryOrder"]);

        // Получить информацию для (ОДНОГО) автомобиля из этого заказа
        DataRow car = drsInv[0];
        strOrderInfo += string.Format("Make: {0}\n", car["Make"]);
        strOrderInfo += string.Format("Color: {0}\n", car["Color"]);
        strOrderInfo += string.Format("Pet Name: {0}\n", car["PetName"]);
      }
      MessageBox.Show(strOrderInfo, "Order Details");
    }
  }
}