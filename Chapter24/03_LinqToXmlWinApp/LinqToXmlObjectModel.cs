using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _03_LinqToXmlWinApp
{
  internal class LinqToXmlObjectModel
  {
    public static XDocument GetXmlInventory()
    {
      try
      {
        XDocument inventoryDoc = XDocument.Load("Inventory.xml");
        return inventoryDoc;
      }
      catch (FileNotFoundException ex)
      {
        MessageBox.Show(ex.Message);
        return null;
      }
    }

    public static void InsertNewElement(string make, string color, string petName)
    {
      // Загрухить текущий документ
      var inventoryDoc = XDocument.Load("Inventory.xml");
      // Сгенерировать случайное число для идентификатора
      var r = new Random();
      // Создать новый объект XElement на основе входных параметров
      var newElement = new XElement("Car", new XAttribute("ID", r.Next(50000)),
        new XElement("Color", color),
        new XElement("Make", make),
        new XElement("PetName", petName));
      // Добавить к объекту XDocument в памяти
      inventoryDoc.Descendants("Inventory").First().Add(newElement);
      // Сохранить изменения на диске
      inventoryDoc.Save("Inventory.xml");
    }

    public static void LookUpColorsForMake(string make)
    {
      // Загрузить текущий документ
      XDocument inventoryDoc = XDocument.Load("Inventory.xml");
      // Найти цвета заданного производителя
      var makeInfo = from car in inventoryDoc.Descendants("Car")
                     where (string)car.Element("Make") == make
                     select car.Element("Color").Value;
      // Построить строку, представляющую каждый цвет
      string data = string.Empty;
      foreach (var item in makeInfo.Distinct())
      {
        data += string.Format("- {0}\n", item);
      }
      // Показать цвета
      MessageBox.Show(data, string.Format("{0} colors: ", make));
    }
  }
}
