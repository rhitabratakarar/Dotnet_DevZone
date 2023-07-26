namespace Quizzy.Interfaces
{
    internal interface IQuestionSet
    {
        public IList<IQuestion> ListOfQuestions { get; set; }
        public IQuestion GetNextQuestion(int questionIndex);
    }
}