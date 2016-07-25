using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Threading;

namespace _01_FirstWorkflowExampleApp
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Welcome to this amazing WF application *****");

      // Получить от пользователя данные для передачи рабочему потоку
      Console.Write("Please enter the data to pass the workflow: ");
      string wfData = Console.ReadLine();

      // Упаковать данные в словарь
      var wfArgs = new Dictionary<string, object> { { "MessageToShow", wfData } };

      // Использовать для информирования первичного потока о необходимости ожидания
      AutoResetEvent waitHandle = new AutoResetEvent(false);

      // Передать словарь рабочему потоку
      WorkflowApplication app = new WorkflowApplication(new Workflow1(), wfArgs);

      // Связать событие с данным объектом app.
      // О факте завершения уведомить другой поток
      // и вывести на консоль соответствующее сообщение
      app.Completed = completedArgs =>
      {
        waitHandle.Set();
        Console.WriteLine("The workflow is done!");
      };

      app.Run();

      // Подождать пока не поступит уведомление о завершении рабочего потока
      waitHandle.WaitOne();
      

      Console.WriteLine("Thanks for playing");
    }
  }
}
