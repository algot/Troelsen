using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_MagicEightBallServiceClient.ServiceReference1;

namespace _03_MagicEightBallServiceClient
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Ask the Magic 8 ball *****\n");
      using (EightBallClient ball = new EightBallClient())
      {
        Console.Write("Your question: ");
        string question = Console.ReadLine();
        string answer = ball.ObtainAnswerToQuestion(question);
        Console.WriteLine("8-ball says: {0}", answer);
      }
      Console.ReadLine();
    }
  }
}
