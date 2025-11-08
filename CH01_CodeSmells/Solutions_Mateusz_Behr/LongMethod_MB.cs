using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class GradeBook
    {
        private int _grade;
        private bool _isFinalized;

        public int Grade => _grade;
        public bool IsFinalized => _isFinalized;

        public void SetGrade(int grade)
        {
            _grade = grade;
        }

        public void FinalizeGrades()
        {
            _isFinalized = true;
        }
    }

    public class Teacher
    {
        public void FinalizeGrades(GradeBook gradeBook)
        {
            gradeBook.SetGrade(90); // Bezpośrednie ustawianie prywatnych pól
            gradeBook.FinalizeGrades(); // Bezpośrednie ustawianie prywatnych pól
        }
    }
}

//1. Usuń bezpośredni dostęp do prywatnych pól klasy GradeBook w metodach klasy Teacher.
// 1. Wprowadź metody publiczne w klasie GradeBook do modyfikowania jej stanu (SetGrade, Finalize).
// 1. Zastąp bezpośrednie ustawienia metodami publicznymi.