namespace Quizzy.Interfaces
{
    internal interface IQuizApplicationService
    {
        public void GenerateQuizQuestionSet();
        public IQuestionSet? GeneratedQuestionSet { get; set; }
    }
}