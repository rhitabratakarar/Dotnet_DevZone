using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class QuizSession : IQuizSession
    {
        public int CurrentQuestionIndex { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public void Dispose()
        {
            this.EndTime = DateTime.Now;
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            CurrentQuestionIndex = default;
            Score = default;
            StartTime = default;
            EndTime = default;
        }


        public void Initialize()
        {
            this.CurrentQuestionIndex = 0;
            this.Score = 0;
            this.StartTime = DateTime.Now;
        }
    }
}
