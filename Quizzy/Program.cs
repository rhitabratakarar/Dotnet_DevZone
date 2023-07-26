using Quizzy.Classes;
using Quizzy.Interfaces;

class Program
{
    public static void Main()
    {
        IQuizApplicationService appService = new DefaultQuizApplicationService();
        IQuizSession quizSession = new QuizSession();
        IApplication app = new Application(appService, quizSession);
        app.InitializeGame();
    }
}