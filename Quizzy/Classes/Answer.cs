using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class Answer : IAnswer
    {
        public Guid AnswerId { get; set; }
        public string? AnswerText { get; set; }
    }
}
