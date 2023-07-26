using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class QuizOptions : IQuizOptions
    {
        public Guid Id { get; set; }
        public IList<IAnswer>? Options { get; set; }
    }
}
