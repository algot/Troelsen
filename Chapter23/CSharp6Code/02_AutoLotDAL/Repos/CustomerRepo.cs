﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_AutoLotDAL.Models;

namespace _02_AutoLotDAL.Repos
{
  public class CustomerRepo : BaseRepo<Customer>, IRepo<Customer>
  {
    public CustomerRepo()
    {
      Table = Context.Customers;
    }

    public int Delete(int id)
    {
      Context.Entry(new Customer() { CustId = id }).State = EntityState.Deleted;
      return SaveChanges();
    }

    public Task<int> DeleteAsync(int id)
    {
      Context.Entry(new Customer() { CustId = id }).State = EntityState.Deleted;
      return SaveChangesAsync();
    }
  }
}