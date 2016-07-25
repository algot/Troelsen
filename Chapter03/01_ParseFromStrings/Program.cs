using System;

class Parser
{
  public static void ParseDate()
  {
    Console.WriteLine("=>Dates and Times: ");

    // Этот конструктор принимает в качестве 
    // аргументов сведения о годе, месяце и дне.
    DateTime dt = new DateTime(2012, 10, 17);

    // Какой день месяца
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    // Сейчас декабрь
    dt = dt.AddMonths(2);
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
    Console.WriteLine("Daylights savings: {0}", dt.IsDaylightSavingTime());

    // Этот конструктор принимает в качестве 
    // аргументов сведения о часах, минутах и секундах
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);

    // Вычитаем 15 минут из текущего времени и выводим результат
    ts = ts.Subtract(new TimeSpan(0, 15, 0));
    Console.WriteLine(ts);
  }
  public void ParseFromStrings()
  {
    Console.WriteLine("=> Data type parsing:");

    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.864");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
  }
  public static void BasicStringFunctionality()
  {
    Console.WriteLine("=> Basic String Functionality:");

    string firstName = @"https://sctestcrm2dk1.sctest.sitecore.net/DevTest2/main.aspx?etc=2&etc=2&id={01C405EF-32AA-E111-A8B6-00155D282904}&pagetype=entityrecord";
    Console.WriteLine("Value of firstName: {0}", firstName);
    // Значение переменной firstName.
    Console.WriteLine("Length of firstName: {0}", firstName.Length);
    // Длина значения переменной firstName
    Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
    Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
    Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));

    Console.WriteLine("firstName contains {0}", firstName.Contains("&etc=2"));
    Console.WriteLine("firstName after replace: {0}", firstName.Replace("&etc=2", ""));

    Console.WriteLine();
  }
}

class Program
{
  static void Main()
  {
    Parser p = new Parser();
    p.ParseFromStrings();

    Parser.ParseDate();
    Parser.BasicStringFunctionality();
  }
}