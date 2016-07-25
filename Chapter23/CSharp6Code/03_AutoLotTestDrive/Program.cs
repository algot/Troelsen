using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_AutoLotDAL.EF;
using _02_AutoLotDAL.Models;
using _02_AutoLotDAL.Repos;

namespace _03_AutoLotTestDrive
{
  public static class Program
  {
    private static void Main(string[] args)
    {
      // Database.SetInitializer(new DataInitializer());
      Console.WriteLine("***** Fun with ADO.NET EF Code First *****\n");

      //var car1 = new Inventory() { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
      //var car2 = new Inventory() { Make = "SmartCar", Color = "Brown", PetName = "Shorty" };

      //AddNewRecord(car1);
      //AddNewRecord(car2);
      //AddNewRecords(new List<Inventory> { car1, car2 });
      //UpdateRecord(car1.CarId);
      PrintAllInventory();

      //ShowAllOrders();

      //ShowAllOrdersEagerlyFetched();

      //PrintAllCustomersAndCreditRisks();
      //var customerRepo = new CustomerRepo();
      //var customer = customerRepo.GetOne(4);
      //customerRepo.Context.Entry(customer).State = EntityState.Detached;
      //var risk = MakeCustomerARisk(customer);
      //PrintAllCustomersAndCreditRisks();
    }

    private static void PrintAllInventory()
    {
      var repo = new InventoryRepo();

      foreach (Inventory c in repo.GetAll())
      {
        Console.WriteLine(c);
      }
    }

    private static void ShowAllOrders()
    {
      var repo = new OrderRepo();
      Console.WriteLine("*********** Pending Orders ***********");
      foreach (var itm in repo.GetAll())
      {
        Console.WriteLine(string.Format("->{0} is waiting on {1}", itm.Customer.FullName, itm.Car.PetName));
      }
    }

    private static void AddNewRecord(Inventory car)
    {
      var repo = new InventoryRepo();
      repo.Add(car);
    }

    private static void AddNewRecords(IList<Inventory> cars)
    {
      var repo = new InventoryRepo();
      repo.AddRange(cars);
    }

    private static void UpdateRecord(int carId)
    {
      var repo = new InventoryRepo();
      var carToUpdate = repo.GetOne(carId);
      if (carToUpdate != null)
      {
        Console.WriteLine("Before change: " + repo.Context.Entry(carToUpdate).State);
        carToUpdate.Color = "Blue";
        Console.WriteLine("After change: " + repo.Context.Entry(carToUpdate).State);
        repo.Save(carToUpdate);
        Console.WriteLine("After save: " + repo.Context.Entry(carToUpdate).State);

        Console.WriteLine();
      }
    }

    private static void ShowAllOrdersEagerlyFetched()
    {
      var context = new AutoLotEntities();

      Console.WriteLine("**************** Pending Orders ***************");

      var orders = context.Orders
        .Include(x => x.Customer)
        .Include(y => y.Car)
        .ToList();
      foreach (var itm in orders)
      {
        Console.WriteLine(string.Format("->{0} is waiting on {1}", itm.Customer.FullName, itm.Car.PetName));
      }
    }

    private static CreditRisk MakeCustomerARisk(Customer customer)
    {
      var context = new AutoLotEntities();

      context.Customers.Attach(customer);
      context.Customers.Remove(customer);
      var creditRisk = new CreditRisk
      {
        FirstName = customer.FirstName,
        LastName = customer.LastName
      };
      context.CreditRisks.Add(creditRisk);
      try
      {
        context.SaveChanges();
      }
      catch (DbUpdateException ex)
      {
        Console.WriteLine(ex);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
      }

      return creditRisk;
    }

    private static void PrintAllCustomersAndCreditRisks()
    {
      Console.WriteLine("***** Customers *****");

      var customerRepo = new CustomerRepo();

      foreach (var cust in customerRepo.GetAll())
      {
        Console.WriteLine(string.Format("->{0} {1} is a Customer.", cust.FirstName, cust.LastName));
      }

      Console.WriteLine("***** Credit Risks *****");
      var creditRiskRepo = new CreditRiskRepo();
      foreach (var risk in creditRiskRepo.GetAll())
      {
        Console.WriteLine(string.Format("->{0} {1} is a Credit Risk!", risk.FirstName, risk.LastName));
      }
    }
  }
}