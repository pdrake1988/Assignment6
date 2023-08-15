using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6.Quiz
{
    public static class Quiz
    {
        public static User User { get; set; }
        public static List<Question> questions = new List<Question>();

        public static void AddQuestion(Question question)
        {
            Quiz.questions.Add(question);
        }

        public static void StartQuiz()
        {
            int score = 0;
            foreach (Question question in questions)
            {
                Console.WriteLine(question.Title);
                Console.WriteLine(question.Description);
                string answer = Console.ReadLine();
                if (answer == question.Answer)
                {
                    score++;
                }
            }
            Console.WriteLine(score.ToString());
        }
    }
}
