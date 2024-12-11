using System.Collections.Generic;

namespace QuizApp
{
    public abstract class Question
    {
        public string QuestionText { get; set; }

        public Question(string questionText)
        {
            this.QuestionText = questionText;
        }
    }

    public class MultipleChoiceQuestion : Question
    {
        public string[] Options { get; set; }
        public int CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(string questionText, int correctAnswer, string[] options) : base(questionText)
        {
            this.Options = options;
            this.CorrectAnswer = correctAnswer;
        }
    }

    public class TrueOrFalseQuestion : Question
    {
        public bool IsTrue { get; set; }

        public TrueOrFalseQuestion(string questionText, bool isTrue) : base(questionText)
        {
            this.IsTrue = isTrue;
        }
    }

    public class OpenEndQuestion : Question
    {
        public List<string> AcceptableAnswers { get; set; }
        
        public OpenEndQuestion(string questionText, List<string> acceptableAnswers) : base(questionText)
        {
            this.AcceptableAnswers = acceptableAnswers;
        }
    }
}
