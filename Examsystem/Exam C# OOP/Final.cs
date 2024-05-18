using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exam_C__OOP
{
    internal class Final : Exam
    {
        public int Grade { get; set; }

        public Final() { }

        public override void CreateExam(int Num_Of_Questions)
        {
            QuestionList = new Question[Num_Of_Questions];

            for(int i = 0;  i < Num_Of_Questions; i++)
            {
                Console.Clear();
                Console.Write($"Please Choose Type Of Question {i + 1}(1 for True and False , 2 for MCQ) : ");
                int Type_Of_Question = int.Parse( Console.ReadLine() );
                Console.Clear();

                if ( Type_Of_Question == 1 )
                {
                    Console.WriteLine("Choose one Answer Question\nPlease Enter The Body Of Question : ");
                    string Body_Of_Question = Console.ReadLine();

                    Console.WriteLine("Please Enter Mark Of The Question : ");
                    int Marks = int.Parse(Console.ReadLine());

                    Console.WriteLine("Please Enter The Right Answer (1 for True , 2 for False) : ");
                    int TheRightAnswer = int.Parse(Console.ReadLine());

                    Question question = new Question();

                    question.answers = new Answers[2];
                    question.answers[0] = new Answers();
                    question.answers[0].AnswerID = 1;
                    question.answers[0].AnswerTxt = "True";
                    question.answers[1] = new Answers();
                    question.answers[1].AnswerID = 2;
                    question.answers[1].AnswerTxt = "False";

                    question = Create_Question("True or False", Body_Of_Question, Marks, TheRightAnswer, question.answers);
                    QuestionList[i] = question;
                    Console.Clear();
                    ///True or False Questions 
                }
                else if( Type_Of_Question == 2 )
                {
                    Console.WriteLine("Choose one Answer Question\nPlease Enter The Body Of Question: ");
                    string Body_Of_Question = Console.ReadLine();

                    Console.WriteLine("Please Enter Mark Of The Question: ");
                    int Marks = int.Parse(Console.ReadLine());
                    Question question = new Question();
                    question.answers = new Answers[3];

                    for (int n = 0; n < 3; n++)
                    {
                        Console.WriteLine($"Please Enter Choice Number {n + 1} : ");
                        string answer = Console.ReadLine();

                        question.answers[n] = new Answers();
                        question.answers[n].AnswerTxt = answer;
                        question.answers[n].AnswerID = n + 1;

                    }

                    Console.WriteLine("Please Enter The Right Answer : ");
                    int TheRightAnswer = int.Parse(Console.ReadLine());
                    question = Create_Question("True or False", Body_Of_Question, Marks, TheRightAnswer , question.answers);
                    QuestionList[i] = question;
                    ////MCQ Question
                }
                else
                {
                    Console.WriteLine("Invalid.\n Please Try Again");
                }
            }
        }
        public static Question Create_Question(string Header_Of_Question, string Body_Of_Question, int Marks, int TheRightAnswer, Answers[] answers)
        {
            Question question = new Question(Header_Of_Question, Body_Of_Question, Marks, answers , TheRightAnswer);
            return question;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam: \n");

            for(int i = 0; i < QuestionList.Length; i++)
            {
                Console.WriteLine("Header Of Question: " + QuestionList[i].Header_Of_Question);
                Console.WriteLine("Question: " + QuestionList[i].Body_Of_Question);
                foreach(var answers in QuestionList[i].answers)
                {
                    Console.WriteLine(answers.AnswerID + " " + answers.AnswerTxt + " ");
                }
                Console.WriteLine("\n Write Answer : ");
                int User_Answer = int.Parse(Console.ReadLine());
                if(User_Answer == QuestionList[i].Correct_Answers)
                {
                    Grade = Grade + QuestionList[i].Marks;
                }
                Console.WriteLine("--------------------------------------");
            }
            for(int i = 0;i < QuestionList.Length;i++)
            {
                Console.WriteLine($"Number Of Question {i + 1} : " + QuestionList[i].Body_Of_Question);
                Console.WriteLine("Correct Answer : " + QuestionList[i].Correct_Answers + "\n");
            }
            Console.WriteLine("The Grade Is : " + Grade);
        }
    }
}
