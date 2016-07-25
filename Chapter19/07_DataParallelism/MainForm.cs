using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_DataParallelism
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    // Новая переменная уровня Form
    private CancellationTokenSource cancelToken = new CancellationTokenSource();

    private void ProcessFiles()
    {
      // Использовать экземпляр ParallelOptions для хранения CancellationToken
      var parOpts = new ParallelOptions
      {
        CancellationToken = cancelToken.Token,
        MaxDegreeOfParallelism = System.Environment.ProcessorCount
      };

      // Загрузить файлы *.jpg и создать новую папку для модифицированных данных
      string[] files = Directory.GetFiles(@"C:\Users\algot\Pictures", "*.jpg", SearchOption.AllDirectories);
      const string newDir = @"C:\ModifiedPictures";
      Directory.CreateDirectory(newDir);

      try
      {
        // Обработать данные изображений в параллельном режиме
        Parallel.ForEach(files, parOpts, currentFile =>
        {
          parOpts.CancellationToken.ThrowIfCancellationRequested();

          string filename = Path.GetFileName(currentFile);
          using (Bitmap bitmap = new Bitmap(currentFile))
          {
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            bitmap.Save(Path.Combine(newDir, filename));


            this.Text = string.Format("Processing {0} on thread {1}", filename,
              Thread.CurrentThread.ManagedThreadId);

          }
        });
      }
      catch (OperationCanceledException ex)
      {
        this.Invoke((Action)delegate
       {
         this.Text = ex.Message;
       });
      }
    }

    private void btnProcessImages_Click_1(object sender, EventArgs e)
    {
      Task.Factory.StartNew(() =>
      {
        ProcessFiles();
      });
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      cancelToken.Cancel();
    }
  }
}
