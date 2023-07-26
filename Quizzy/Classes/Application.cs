using Quizzy.Interfaces;
using System.Diagnostics;

namespace Quizzy.Classes
{
    internal class Application: IApplication
    {
        private readonly IQuizApplicationService _quizService;
        private readonly IQuizSession _quizSession; 
        public Application(IQuizApplicationService quizApplicationService, IQuizSession quizSession, )
        {
            this._quizService = quizApplicationService;
            this._quizSession = quizSession;
        }

        public void InitializeGame()
        {
            Console.WriteLine("Welcome.");
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine()!;

            using (this._quizSession)
            {
                this._quizSession.Initialize();
                Console.WriteLine("Generating Questions, Please wait..."); ;
                Thread.Sleep(2);
                this._quizService.GenerateQuizQuestionSet();
                int questionCount = 0;
                if (this._quizService.GeneratedQuestionSet != null)
                    questionCount = this._quizService.GeneratedQuestionSet.ListOfQuestions.Count;
                else
                    Environment.Exit(0);
                Console.WriteLine("Question Set Generated.");

                // start the game
                IQuestionSet generatedQuestionSet = this._quizService.GeneratedQuestionSet;

                for(int i = 0; i < questionCount; i ++)
                {
                    IQuestion currentQuestion = generatedQuestionSet.GetNextQuestion(i);
                    this._quizSession.CurrentQuestionIndex = i;

                    Console.WriteLine($"Q{i}. {currentQuestion.QuestionText} Choose the index.");

                    // show the options
                    for(int j = 0; j < currentQuestion.Options.Options.Count; j ++)
                    {
                        Console.WriteLine($"{j}. {currentQuestion.Options.Options[j].AnswerText}");
                    }

                    Console.Write("Your Answer: ");
                    int assumedAnswerIndex = Convert.ToInt32(Console.ReadLine());

                    // check whether the answer is valid or not, and modify the score.
                    if (currentQuestion.ValidAnswer.AnswerId == currentQuestion.Options.Options[assumedAnswerIndex].AnswerId)
                        this._quizSession.Score += 1;
                }
                Console.WriteLine("Your Score: " + this._quizSession.Score);
            }
        }
    }
}
