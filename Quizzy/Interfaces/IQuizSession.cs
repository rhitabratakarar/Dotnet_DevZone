namespace Quizzy.Interfaces
{
    internal interface IQuizSession: IDisposable
    {
        public int CurrentQuestionIndex { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public void Initialize();
    }
}