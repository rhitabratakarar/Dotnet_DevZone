namespace Quizzy.Interfaces
{
    public interface IAnswer
    {
        public Guid AnswerId { get; set; }
        public string? AnswerText { get; set; }
    }
}