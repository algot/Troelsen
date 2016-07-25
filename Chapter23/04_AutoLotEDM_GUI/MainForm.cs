using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotDAL;

namespace _04_AutoLotEDM_GUI
{
  public partial class MainForm : Form
  {
    AutoLotEntities context = new AutoLotEntities();
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      context.SaveChanges();
      MessageBox.Show("Data saved!");
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      context.Dispose();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Привязать коллекцию ObjectSet<Inventory> к сетке
      context.Inventories.Load();
      gridInventory.DataSource = context.Inventories;
    }
  }
}
