using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class InappropriateIntimacy_MB
    {
        public class Course
        {
            private int _credits;
            private bool _isCompleted;

            public int Credits
            {
                get { return _credits; }
                private set { _credits = value; }
            }

            public bool IsCompleted
            {
                get { return _isCompleted; }
                private set { _isCompleted = value; }
            }

            public void Complete(int credits)
            {
                Credits = credits;
                IsCompleted = true;
            }
        }

        public class Student
        {
            public void CompleteCourse(Course course)
            {
                course.Complete(3);
            }
        }
    }
}
