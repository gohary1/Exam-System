using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class Practical : Exam
    {
        public Practical(){}

        public override void CreateExam(int Num_Of_Questions)
        {
            QuestionList = new Question[Num_Of_Questions];
            for (int i = 0; i< Num_Of_Questions; i++)
            {
                Console.WriteLine("You Chose Practical Exam\nChoose one Answer Question\nPlease Enter The Body Of Question: ");
                string Body_Of_Question = Console.ReadLine();

                Console.WriteLine("Please Enter Mark Of The Question: ");
                int Marks = int.Parse(Console.ReadLine());

                Question question = new Question();
                Console.WriteLine("Choices of Three Questions Are: ");

                question.answers = new Answers[3];
                for(int n = 0; n < 3; n++)
                {
                    Console.WriteLine($"Please Enter Choice Number {n+1} : " );

                    string answer = Console.ReadLine();
                    question.answers[n] = new Answers();
                    question.answers[n].AnswerTxt = answer;
                    question.answers[n].AnswerID = n + 1;
                }
                Console.WriteLine("Please Enter The Right Answer : ");

                int TheRightAnswer = int.Parse(Console.ReadLine());
                question = Create_Question("MCQ",Body_Of_Question, TheRightAnswer, Marks, question.answers);
                QuestionList[i] = question;
                Console.Clear();
            
            } 

        }

        public Question Create_Question(string Header_Of_Question,string Body_Of_Question, int Marks, int Correct_Answers, Answers[] answers)
        {
            Question question = new Question(Header_Of_Question, Body_Of_Question, Marks, answers, Correct_Answers);
            Console.Clear();
            return question;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam: ");
            for(int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine("Header Of Question: " + QuestionList[i].Header_Of_Question);
                Console.WriteLine("Question: " + QuestionList[i].Body_Of_Question);
                Console.WriteLine("Answers Of Questions: ");
                foreach(var answer in QuestionList[i].answers)
                {
                    Console.WriteLine(answer.AnswerID + " " + answer.AnswerTxt + " ");
                }
                Console.WriteLine("\nWrite Your Answer :");
                int User_Answer = int.Parse(Console.ReadLine());
                if(User_Answer != 0)
                {
                    Console.WriteLine($"Correct Answer Number Is {i + 1} : " + QuestionList[i].Correct_Answers);

                }
                Console.WriteLine();
            }
        }
    }
}
