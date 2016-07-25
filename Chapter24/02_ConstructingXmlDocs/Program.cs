using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02_ConstructingXmlDocs
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      // CreateFullXDocument();
      CreateRootAndChildren();
    }

    private static void CreateFullXDocument()
    {
      XDocument inventoryDoc =
        new XDocument(
          new XDeclaration("1.0", "utf-8", "yes"),
          new XComment("Current Inventory of cars."),
          new XProcessingInstruction("xml-stylesheet",
            "href=MyStyles.css title='Compact' type='text/css'"),
          new XElement("Inventory",
            new XElement("Car", new XAttribute("ID", "1"),
              new XElement("Color", "Green"),
              new XElement("Make", "BMW"),
              new XElement("PetName", "Stan")
              ),
            new XElement("Car", new XAttribute("ID", "2"),
              new XElement("Color", "Pink"),
              new XElement("Make", "Yugo"),
              new XElement("PetName", "Melvin")
              )
            )
          );
      inventoryDoc.Save("SimpleInventory.xml");
    }

    private static void CreateRootAndChildren()
    {
      var inventoryDoc =
        new XElement("Inventory",
          new XElement("Car", new XAttribute("ID", "1"),
            new XElement("Color", "Green"),
            new XElement("Make", "BMW"),
            new XElement("PetName", "Stan")
            ),
          new XElement("Car", new XAttribute("ID", "2"),
            new XElement("Color", "Pink"),
            new XElement("Make", "Yugo"),
            new XElement("PetName", "Melvin")
            )
          );
      inventoryDoc.Save("SimpleInventory.xml");
    }
  }
}
