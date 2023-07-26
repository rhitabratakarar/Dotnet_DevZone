using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class Question : IQuestion
    {
        public Guid Id { get; set; }
        public string? QuestionText { get; set; }
        public IAnswer? ValidAnswer { get; set; }
        public IQuizOptions? Options { get; set; }
    }
}
