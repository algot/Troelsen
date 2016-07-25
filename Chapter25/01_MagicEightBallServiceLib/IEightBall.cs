using System.ServiceModel;

namespace _01_MagicEightBallServiceLib
{
  [ServiceContract]
  public interface IEightBall
  {
    [OperationContract]
    string ObtainAnswerToQuestion(string userQuestion);
  }
}