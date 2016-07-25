namespace _03_StaticData
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class SavingAccount
  {
    public double currBalance;
    // Статический элемент данных.
    public static double currInterestRate;
    // Конструктор.
    public SavingAccount(double balance)
    {
      currBalance = balance;
    }
    static SavingAccount()
    {
      Console.WriteLine("In static ctor.");
      currInterestRate = 0.04;
    }
    // Статические члены для установки/получения процентной ставки.
    public static void SetIterestRate(double newRate)
    {
      currInterestRate = newRate;
    }
    public static double GetInterestRate()
    {
      return currInterestRate;
    }
  }
}
