﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_AutoLotDAL.Models;

namespace _02_AutoLotDAL.Repos
{
  public class CreditRiskRepo : BaseRepo<CreditRisk>, IRepo<CreditRisk>
  {
    public CreditRiskRepo()
    {
      Table = Context.CreditRisks;
    }

    public int Delete(int id)
    {
      Context.Entry(new CreditRisk() { CustId = id }).State = EntityState.Deleted;
      return SaveChanges();
    }

    public Task<int> DeleteAsync(int id)
    {
      Context.Entry(new CreditRisk() { CustId = id }).State = EntityState.Deleted;
      return SaveChangesAsync();
    }
  }
}