using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_StaticData
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with Static Data *****\n");
      SavingAccount sv1 = new SavingAccount(50);
      SavingAccount sv2 = new SavingAccount(100);
      // Вывести текущую процентную ставку.
      Console.WriteLine("Interest rate is {0}", SavingAccount.GetInterestRate());
      // Создать новый объект. Это не очистит поле currInterestRate.
      SavingAccount sv3 = new SavingAccount(300);
      Console.WriteLine("Interest rate is {0}", SavingAccount.GetInterestRate());
    }
  }
}
