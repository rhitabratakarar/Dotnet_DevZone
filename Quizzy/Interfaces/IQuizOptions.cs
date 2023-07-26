namespace Quizzy.Interfaces
{
    public interface IQuizOptions
    {
        public Guid Id { get; set; }
        public IList<IAnswer> Options { get; set; }
    }
}