using System;
using System.Diagnostics;
using System.Linq;

namespace _01_ProcessManipulator
{
  public class Class1
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("***** Fun wigh Processes *****\n");
      ListAllRunningProcesses();
      GetSpecificProcess();

      Console.WriteLine("***** Enter PID of process to investigate *****");
      Console.Write("PID: ");
      string pID = Console.ReadLine();
      int theProcId = int.Parse(pID);

      // EnumThreadsForPid(theProcId);

      StartAndKillProcess();
    }

    private static void ListAllRunningProcesses()
    {
      // Получить все процессы на локальной машине, отстортированные по ID
      var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;

      // Вывести для каждого процесса PID и имя
      foreach (var p in runningProcs)
      {
        var info = string.Format("-> PID: {0}\tName: {1}", p.Id, p.ProcessName);
        Console.WriteLine(info);
      }
      Console.WriteLine("**************\n");
    }

    private static void GetSpecificProcess()
    {
      Process theProc;

      try
      {
        theProc = Process.GetProcessById(4);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    private static void EnumThreadsForPid(int pID)
    {
      Process theProc = null;
      try
      {
        theProc = Process.GetProcessById(pID);
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message);
        return;
      }

      Console.WriteLine("Here are the the loaded modules for: {0}", theProc.ProcessName);
      ProcessModuleCollection theMods = theProc.Modules;

      foreach (ProcessModule pm in theMods)
      {
        var info = string.Format("-> Mod Name: {0}", pm.ModuleName);
        Console.WriteLine(info);
      }
    }

    private static void StartAndKillProcess()
    {
      Process ieProc = null;
      // Запустить IE и перейти на facebook.com
      try
      {
        var startInfo = new ProcessStartInfo("IExplore.exe", "facebook.com")
        {
          WindowStyle = ProcessWindowStyle.Maximized
        };

        ieProc = Process.Start(startInfo);
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine(ex.Message);
      }

      Console.WriteLine("--> Hit enter to kill {0}...", ieProc.ProcessName);
      Console.ReadLine();

      // Уничтожить процесс iexplore.exe
      try
      {
        ieProc.Kill();
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}