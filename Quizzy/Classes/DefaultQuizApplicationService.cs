using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class DefaultQuizApplicationService : IQuizApplicationService
    {
        private readonly IList<IQuestion> questionDatabase = new List<IQuestion>();
        private readonly IList<IQuestionSet> questionSetDatabase = new List<IQuestionSet>();

        public IQuestionSet? GeneratedQuestionSet { get; set; }

        public void GenerateQuizQuestionSet()
        {
            GenerateQuestionDatabase();
            GenerateQuestionSetDatabase();
        }

        public void GenerateQuestionDatabase()
        {
            IAnswer answer1 = new Answer() { AnswerId = Guid.NewGuid(), AnswerText = "Paris" };
            IAnswer answer2 = new Answer() { AnswerId = Guid.NewGuid(), AnswerText = "London" };
            IAnswer answer3 = new Answer() { AnswerId = Guid.NewGuid(), AnswerText = "Berlin" };
            IAnswer answer4 = new Answer() { AnswerId = Guid.NewGuid(), AnswerText = "Washington" };

            IList<IAnswer> answers = new List<IAnswer>()
            {
                answer1, answer2, answer3, answer4
            };

            this.questionDatabase.Add(new Question()
            {
                Id = Guid.NewGuid(),
                QuestionText = "What is the capital of France?",
                Options = new QuizOptions() { Id = Guid.NewGuid(), Options = answers },
                ValidAnswer = answer1
            });
        }
        public void GenerateQuestionSetDatabase()
        {
            Random random = new();
            IQuestion randomQuestion = this.questionDatabase[random.Next(this.questionDatabase.Count)];
            IQuestionSet questionSet = new QuestionSet(new List<IQuestion>() { randomQuestion });
            this.questionSetDatabase.Add(questionSet);
        }
    }
}
