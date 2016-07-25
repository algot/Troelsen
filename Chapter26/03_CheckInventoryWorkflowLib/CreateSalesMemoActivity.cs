using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace _03_CheckInventoryWorkflowLib
{

  public sealed class CreateSalesMemoActivity : CodeActivity
  {
    // Два свойства для специального действия
    public InArgument<string> Make { get; set; }
    public InArgument<string> Color { get; set; }

    // Если действие возвращает значение, унаследовать его от
    // CodeActivity<TResult> и вернуть значение из метода Execute()
    protected override void Execute(CodeActivityContext context)
    {
      // Вывести сообщение в локальный файл
      StringBuilder salesMessage = new StringBuilder();
      salesMessage.AppendLine("***** Attention sales team! *****");
      salesMessage.AppendLine("Please order the following ASAP!");
      salesMessage.AppendFormat("1 {0} {1}\n", context.GetValue(Color), context.GetValue(Make));
      salesMessage.AppendLine("*************************");

      System.IO.File.WriteAllText("SalesMemo.txt", salesMessage.ToString());

    }

    // Define an activity input argument of type string
    public InArgument<string> Text { get; set; }
  }
}
