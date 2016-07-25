using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace _02_MyWordPad
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      SetF1CommandBinding();
    }

    private void SetF1CommandBinding()
    {
      CommandBinding helpBinding = new CommandBinding(ApplicationCommands.Help);
      helpBinding.CanExecute += CanHelpExecute;
      helpBinding.Executed += HelpExecuted;
      CommandBindings.Add(helpBinding);
    }

    private static void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      MessageBox.Show("Look, it is not that difficult. Just type something!", "Help!");
    }

    private static void CanHelpExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }

    private void MouseEnterExitArea(object sender, MouseEventArgs e)
    {
      statBarText.Text = "Exit the Application";
    }

    private void MouseLeaveArea(object sender, MouseEventArgs e)
    {
      statBarText.Text = "Ready";
    }

    private void FileExit_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void MouseEnterToolsHintArea(object sender, MouseEventArgs e)
    {
      statBarText.Text = "Show Spelling Suggestion";
    }

    private void ToolsSpellingHints_Click(object sender, RoutedEventArgs e)
    {
      string spellingHints = string.Empty;

      // Попробовать получить ошибку правописания в тукущем положении курсора
      SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
      if (error != null && error.Suggestions.Any())
      {
        foreach (string s in error.Suggestions)
        {
          spellingHints += string.Format("{0}\n", s);
        }
        // Отобразить подсказки и раскрыть Expander
        lblSpellingHints.Content = spellingHints;
        expanderSpelling.IsExpanded = true;
      }
    }

    private void OpenCmdExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      // Создать диалоговое окно открытия файла, отображающее только txt файлы
      OpenFileDialog openDlg = new OpenFileDialog();
      openDlg.Filter = "Text Files |*.txt";

      // Был ли совершен клик на кнопке OK
      if (true == openDlg.ShowDialog())
      {
        // Загрузить содержимое файла
        string dataFromFile = File.ReadAllText(openDlg.FileName);

        // Отобразить строку в TextBox
        txtData.Text = dataFromFile;
      }
    }

    private void SaveCmdExecuted(object sender, ExecutedRoutedEventArgs e)
    {
      SaveFileDialog saveDlg = new SaveFileDialog();
      saveDlg.Filter = "Text Files |*.txt";

      // Был ли совершен клик на кнопке OK
      if (true == saveDlg.ShowDialog())
      {
        // Сохранить данные из TextBox в указанном файле
        File.WriteAllText(saveDlg.FileName, txtData.Text);
      }
    }

    private void OpenCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }

    private void SaveCmdCanExecute(object sender, CanExecuteRoutedEventArgs e)
    {
      e.CanExecute = true;
    }
  }
}
