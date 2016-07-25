using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using _04_MathServiceLibrary;

namespace _05_MathWindowsServiceHost
{
  public partial class MathWinService : ServiceBase
  {
    // Переменная-член типа ServiceHost
    private ServiceHost myHost;

    public MathWinService()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      // Проверить для подстраховки
      if (myHost != null)
      {
        myHost.Close();
      }
      // Создать хост и указать URL для привязки HTTP
      myHost = new ServiceHost(typeof (MathWinService), new Uri("http://localhost:8080/MathServiceLibrary"));
      // Выбрать стандартные конечные точки
      myHost.AddDefaultEndpoints();

      //myHost = new ServiceHost(typeof(MathWinService));
      //// Указать ABC в коде
      //Uri address = new Uri("http://localhost:8080/MathServiceLibrary");
      //WSHttpBinding binding = new WSHttpBinding();
      //Type contract = typeof(IBasicMath);
      //// Добавить конечную точку
      //myHost.AddServiceEndpoint(contract, binding, address);
      // Открыть хост
      myHost.Open();
    }

    protected override void OnStop()
    {
      if (myHost != null)
      {
        myHost.Close();
      }
    }
  }
}
