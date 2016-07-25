using System;

class Program
{
  // Специальное перечисление
  enum EmpType
  {
    Manager = 102,
    Grunt = 10,
    Contractor = 100,
    VicePresident = 9
  }

  static void Main()
  {
    Console.WriteLine("***** Fun with Enums *****");
    // Создание типа Contractor
    EmpType emp = EmpType.Contractor;
    AskForBonus(emp);

    Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
    Console.WriteLine("emp is a {0}", emp.ToString());
    Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);

    EmpType e2 = EmpType.Contractor;
    DayOfWeek day = DayOfWeek.Monday;
    ConsoleColor cc = ConsoleColor.Gray;

    EvaluateEnum(e2);
    EvaluateEnum(day);
    EvaluateEnum(cc);
  }

  // Использование перечислений в качестве параметра
  static void AskForBonus(EmpType e)
  {
    switch (e)
    {
      case EmpType.Manager:
        Console.WriteLine("How about stock options instead?");
        break;
      case EmpType.Grunt:
        Console.WriteLine("You have got to be kidding...");
        break;
      case EmpType.Contractor:
        Console.WriteLine("You already have enough cash...");
        break;
      case EmpType.VicePresident:
        Console.WriteLine("VERY GOOD, Sir!");
        break;
    }
  }

  // Этот метод отображает детали любого перечисления.
  static void EvaluateEnum(Enum e)
  {
    Console.WriteLine("=> Information about {0}", e.GetType().Name);
    Console.WriteLine("Underlying storage type {0}", Enum.GetUnderlyingType(e.GetType()));
    // Получение всех пар значений для входного параметра.
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members", enumData.Length);
    for (int i = 0; i < enumData.Length; i++)
    {
      Console.WriteLine("Name: {}, Value: {0:D}", enumData.GetValue(i));
    }
    Console.WriteLine();
  }
}