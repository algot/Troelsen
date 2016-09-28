using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_WpfControlsAndAPIs
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
      this.inkRadio.IsChecked = true;
      this.comboColors.SelectedIndex = 0;

      PopulateDocument();
      EnableAnnotations();

      //btnSaveDoc.Click += (o, s)=>
    }

    private void RadioButtonClicked(object sender, RoutedEventArgs e)
    {
      // В зависимости от кнопки, отправившей событие, переключить InkCanvas
      switch ((sender as RadioButton).Content.ToString())
      {
        case "Ink Mode!":
          this.myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
          this.comboColors.IsEnabled = true;
          break;
        case "Erase Mode!":
          this.myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
          this.comboColors.IsEnabled = false;
          break;
        case "Select Mode!":
          this.myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
          this.comboColors.IsEnabled = false;
          break;
      }
    }

    private void ColorChanged(object sender, SelectionChangedEventArgs e)
    {
      string colorToUse = (this.comboColors.SelectedItem as StackPanel).Tag.ToString();

      this.myInkCanvas.DefaultDrawingAttributes.Color = (Color) ColorConverter.ConvertFromString(colorToUse);
    }

    private void SaveData(object sender, RoutedEventArgs e)
    {
      // Сохранить все данные InkCanvas в локальном файле
      using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Create))
      {
        this.myInkCanvas.Strokes.Save(fs);
        fs.Close();
      }
    }

    private void LoadData(object sender, RoutedEventArgs e)
    {
      // Наполнить StrokeCollection из файла
      using (FileStream fs = new FileStream("StrokeData.bin", FileMode.Open, FileAccess.Read))
      {
        StrokeCollection strokes = new StrokeCollection(fs);
        this.myInkCanvas.Strokes = strokes;
      }
    }

    private void Clear(object sender, RoutedEventArgs e)
    {
      // Очистить все штрихи
      this.myInkCanvas.Strokes.Clear();
    }

    private void PopulateDocument()
    {
      // Добавить данные в List
      this.listOfFunFacts.FontSize = 14;
      this.listOfFunFacts.MarkerStyle = TextMarkerStyle.Circle;
      this.listOfFunFacts.ListItems.Add(
        new ListItem(new Paragraph(new Run("Fixed documents are for WYSIWYG print ready docs!"))));
      this.listOfFunFacts.ListItems.Add(
        new ListItem(new Paragraph(new Run("The API supports tables and embedded figures!"))));
      this.listOfFunFacts.ListItems.Add(
        new ListItem(new Paragraph(new Run("Flow documents are read only!"))));
      this.listOfFunFacts.ListItems.Add(
        new ListItem(new Paragraph(new Run("BlockUIContainer allows you to embed WPF controls in the document!"))));
      
      // Добавить некоторые данные в элемент Paragraph
      
      // Первая часть абзаца
      Run prefix = new Run("This paragraph was generated ");
      
      // Середина абзаца
      Bold b = new Bold();
      Run infix = new Run("dynamically");
      infix.Foreground = Brushes.Red;
      infix.FontSize = 30;
      b.Inlines.Add(infix);

      // Последняя часть абзаца
      Run suffix = new Run(" at runtime!");

      // Добавить все части в коллекцию встроенных элементов Paragraph
      this.paraBodyText.Inlines.Add(prefix);
      this.paraBodyText.Inlines.Add(infix);
      this.paraBodyText.Inlines.Add(suffix);
    }

    private void EnableAnnotations()
    {
      // Create the annotationService object that works
      // with our FlowDocumentReader
      AnnotationService anoService = new AnnotationService(myDocumentReader);
      
      // Create a MemoryStream that will hold the annotations
      MemoryStream anoStream = new MemoryStream();

      // Create xml-Based store based on MemoryStream
      // You could use this object to programmatically add, delete,
      // or find annotations
      AnnotationStore store = new XmlStreamStore(anoStream);

      // Enable annotation services
      anoService.Enable(store);
    }

  }
}
