using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _01_WpfAppAllCode
{
  class Program : Application
  {
    [STAThread]
    private static void Main(string[] args)
    {
      // Обработать события Start и Exit и затем запустить приложение
      Program app = new Program();
      app.Startup += new StartupEventHandler(AppStartUp);
      app.Exit += new ExitEventHandler(AppExit);
      app.Run();
    }

    private static void AppExit(object sender, ExitEventArgs e)
    {
      MessageBox.Show("App has exited");
    }

    private static void AppStartUp(object sender, StartupEventArgs e)
    {
      // Проверить аргументы коммандной строки
      Application.Current.Properties["GodMode"] = false;
      foreach (string arg in e.Args)
      {
        if (arg.ToLower() == "/godmode")
        {
          Application.Current.Properties["GodMode"] = true;
          break;
        }
      }

      MainWindow wnd = new MainWindow("My better WPF app!", 200, 300);
      //// Создать объект Window и установить некоторые базовые свойства
      //var mainWindow = new Window
      //{
      //  Title = "My first WPF App!",
      //  Height = 200,
      //  Width = 300,
      //  WindowStartupLocation = WindowStartupLocation.CenterScreen
      //};
      //mainWindow.Show();
    }
  }
}
