using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class Subject
    {
        public Exam Exam_Of_Subject { get; set; }
        public int SubjectID {  get; set; }
        public string SubjectName { get; set; }


        public Subject (string SubjectName , int _SubjectID)
        {
            this.SubjectName = SubjectName;
            this.SubjectID = _SubjectID;
        }

        public void CreateExams()
        {
            Console.Write("Please Enter The Type Of Exam You Want To Create (1 for Practical , 2 for Final ) : ");
            int input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.Write("Please Enter The Time Of The Exam (Minuts): ");
                int Minuts_Of_Prac = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Number Of Question : ");
                int Num_Of_Questions = int.Parse(Console.ReadLine());
                Console.Clear();

                Exam_Of_Subject = new Practical();
                Exam_Of_Subject.time = Minuts_Of_Prac;
                Exam_Of_Subject.Num_Of_Questions = Num_Of_Questions;
                Exam_Of_Subject.CreateExam(Num_Of_Questions);
                /////// The Practical Exam
            }
            else if(input == 2)
            {
                Console.Write("Please Enter The Time Of The Exam (Minuts): ");
                int Minuts_Of_Prac = int.Parse(Console.ReadLine());

                Console.Write("Please Enter Number Of Question : ");
                int Num_Of_Questions = int.Parse(Console.ReadLine());
                Console.Clear();

                Exam_Of_Subject = new Final();
                Exam_Of_Subject.time = Minuts_Of_Prac;
                Exam_Of_Subject.Num_Of_Questions= Num_Of_Questions;
                Exam_Of_Subject.CreateExam(Num_Of_Questions);
                //// The Final Exam
            }
            else
            {
                Console.WriteLine("Invalid.\nPlease Try Again");
            }
        }
    }
}
