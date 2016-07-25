using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _01_WpfAppAllCode
{
  class MainWindow : Window
  {
    private Button btnExitApp = new Button();
    public MainWindow(string windowTitle, int height, int width)
    {
      btnExitApp.Click += btnExitApp_Clicked;
      btnExitApp.Content = "Exit Application";
      btnExitApp.Height = 25;
      btnExitApp.Width = 100;

      this.AddChild(btnExitApp);

      this.Title = windowTitle;
      this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
      this.Height = height;
      this.Width = width;

      this.Show();

      this.Closing += MainWindow_Closing;
      this.Closed += MainWindow_Closed;

      this.MouseMove += MainWindow_MouseMove;

      this.KeyDown += MainWindow_KeyDown;
    }

    private void MainWindow_KeyDown(object sender, KeyEventArgs e)
    {
      btnExitApp.Content = e.Key.ToString();
    }

    private void MainWindow_MouseMove(object sender, MouseEventArgs e)
    {
      // Установить в заголовке окна текущие координаты мыши
      this.Title = e.GetPosition(this).ToString();
    }

    private void MainWindow_Closed(object sender, EventArgs e)
    {
      MessageBox.Show("See ya!");
    }

    private static void MainWindow_Closing(object sender, CancelEventArgs e)
    {
      // Проверить, действительно ли пользователь хочет закрыть окно
      const string msg = "Do you want to close without saving?";

      MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);

      if (result == MessageBoxResult.No)
      {
        e.Cancel = true;
      }
    }

    private void btnExitApp_Clicked(object sender, RoutedEventArgs e)
    {
      if ((bool)Application.Current.Properties["GodMode"])
      {
        MessageBox.Show("Cheater!");
      }
      this.Close();
    }
  }
}
