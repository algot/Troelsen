using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEbookReader
{
  public partial class EbookReader : Form
  {
    private string theEBook = "";

    public EbookReader()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      WebClient wc = new WebClient();
      wc.DownloadStringCompleted += (s, eArgs) =>
      {
        theEBook = eArgs.Result;
        txtBook.Text = theEBook;
      };
      // Загрузить книгу 
      wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/cache/epub/98/pg98.txt"));
    }

    private void btnGetStats_Click(object sender, EventArgs e)
    {
      // Получить слова из электронной книги
      var words = theEBook.Split(new[] {' ', '\u000A', ',', '.', ';', ':', '-', '?', '/'},
        StringSplitOptions.RemoveEmptyEntries);
      string[] tenMostCommon = null;
      var longestWord = string.Empty;

      Parallel.Invoke(
        () =>
        {
          // Найти 10 наиболее часто встречающихся слов
          tenMostCommon = FindTenMostCommon(words);
        },
        () =>
        {
          // Получить самое длинное слово
          longestWord = FindLongestWord(words);
        });
      // Когда все задачи завершены, построить строку, показывающую всю статистику в окне сообщений
      StringBuilder bookStats = new StringBuilder("Ten most common words are:\n");
      foreach (string s in tenMostCommon)
      {
        bookStats.AppendLine(s);
      }
      bookStats.AppendFormat("Longest word is: {0}", longestWord);
      bookStats.AppendLine();
      MessageBox.Show(bookStats.ToString(), "Book info");
    }

    private static string[] FindTenMostCommon(string[] words)
    {
      var frequencyOrder = from word in words
        where word.Length > 6
        group word by word
        into g
        orderby g.Count() descending
        select g.Key;
      string[] commonWords = (frequencyOrder.Take(10).ToArray());
      return commonWords;
    }

    private static string FindLongestWord(string[] words)
    {
      return (from w in words orderby w.Length descending select w).FirstOrDefault();
    }
  }
}