﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDisconnectedLayer;

namespace _05_InventoryDALDisconnectedGUI
{
  public partial class MainForm : Form
  {
    private InventoryDALDisLayer dal = null;

    public MainForm()
    {
      InitializeComponent();

      string cnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=AutoLot;" +
                     "Integrated Security=True;Pooling=False";
      // Создать объект доступа к данным
      dal = new InventoryDALDisLayer(cnStr);
      // Заполнить сетку
      inventoryGrid.DataSource = dal.GetAllInventory();
    }

    private void btnUpdateInventory_Click(object sender, EventArgs e)
    {
      // Получить модифицированные данные из сетки
      DataTable changedDT = (DataTable) inventoryGrid.DataSource;
      try
      {
        // Зафиксировать изменения
        dal.UpdateInventory(changedDT);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
