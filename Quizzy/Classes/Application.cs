using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class Application: IApplication
    {
        private readonly IQuizApplicationService _quizService;
        public Application(IQuizApplicationService quizApplicationService)
        {
            this._quizService = quizApplicationService;
        }

        public void InitializeGame()
        {
            throw new NotImplementedException();
        }
    }
}
