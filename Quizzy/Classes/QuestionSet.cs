using Quizzy.Interfaces;

namespace Quizzy.Classes
{
    internal class QuestionSet : IQuestionSet
    {
        public IList<IQuestion> ListOfQuestions { get; set; }

        public QuestionSet(IList<IQuestion> listOfQuestions)
        {
            this.ListOfQuestions = listOfQuestions;
        }

        public IQuestion GetNextQuestion(int questionIndex)
        {
            try
            {
                IQuestion nextQuestion = ListOfQuestions[questionIndex];
                return nextQuestion;
            }
            catch(IndexOutOfRangeException e)
            {
                throw e;
            }
        }
    }
}
