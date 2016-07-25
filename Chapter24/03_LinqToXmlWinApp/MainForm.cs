using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_LinqToXmlWinApp
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      txtInventory.SelectionStart = 0;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Отобразить текущий XML документ Inventory в элементе UI TextBox
      txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
    }

    private void btnAddNewItem_Click(object sender, EventArgs e)
    {
      // Добавить новый элемент к документу
      LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);
      // Отобразить текущий XML-документ Inventory в элементе UI TextBox
      txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
    }

    private void btnLookUpColors_Click(object sender, EventArgs e)
    {
      LinqToXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
    }
  }
}
