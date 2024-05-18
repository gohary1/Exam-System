using System;
using System.Diagnostics;

namespace Exam_C__OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject("C#" , 10);
            subject.CreateExams();

            Console.Clear();
            Console.WriteLine("Do You Want To Start Exam (Y | N) : ");

            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear() ;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam_Of_Subject.ShowExam();
                Console.WriteLine($"Elapsed Time {stopwatch.Elapsed}");
            }
            
        }
    }
}
