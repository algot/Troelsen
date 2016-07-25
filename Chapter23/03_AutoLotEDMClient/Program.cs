using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL;

namespace _03_AutoLotEDMClient
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      PrintCustomerOrders("4");
    }

    private static void PrintCustomerOrders(string custId)
    {
      int id = int.Parse(custId);
      using (AutoLotEntities context = new AutoLotEntities())
      {
        var carsOnOrder = from o in context.Orders
          where o.CustId == id
          select o.Inventory;
        Console.WriteLine("\nCustomer has {0} orders pending: ", carsOnOrder.Count());
        foreach (var item in carsOnOrder)
        {
          Console.WriteLine("-> {0} {1} named {2}.",
            item.Color, item.Make, item.PetName);
        }
      }
    }

    private static void CallStoredProc()
    {
      using (AutoLotEntities context = new AutoLotEntities())
      {
        
      }
    }
  }
}
