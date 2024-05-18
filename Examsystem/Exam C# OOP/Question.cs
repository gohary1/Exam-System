using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal class Question
    {
        public Question() { }

        public string Header_Of_Question {  get; set; }
        public string Body_Of_Question { get; set; }
        public int Marks { get; set; }

        public Answers[] answers { get; set; }

        public int Correct_Answers {  get; set; }

        public Question (string _Header_Of_Question, string _Body_Of_Question, int _Marks, Answers[] _answers,int _Correct_Answers)
        {
            this.Header_Of_Question = _Header_Of_Question;
            this.Body_Of_Question = _Body_Of_Question;
            this.Marks = _Marks;
            this.answers = _answers;
            this.Correct_Answers = _Correct_Answers;
        }
    }
}
