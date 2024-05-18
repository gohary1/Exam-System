using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_C__OOP
{
    internal abstract class Exam
    {
        internal int Num_Of_Questions;

        public int time { get; set; }
        public int NumberOfQuestion { get; set; }

        public Question[] QuestionList { get; set; }

        public abstract void CreateExam(int Num_Of_Questions);
        public abstract void ShowExam();
    }

    
}
