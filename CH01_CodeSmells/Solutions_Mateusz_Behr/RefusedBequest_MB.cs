using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    //Masz klasę Manager dziedziczącą po Employee, ale Manager nie używa wszystkich metod odziedziczonych po Employee.Twoim zadaniem jest usunięcie niepotrzebnego dziedziczenia i wprowadzenie bardziej odpowiedniego rozwiązania.


    //    Kod do refaktoryzacji:

    //    ```csharp
    public interface IEmployee
    {
        void Work();
        void AttendMeeting();
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public void Work()
        {
             /* Implementacja */
        }

        public void AttendMeeting()
        {
             /* Implementacja */
        }
    }

    public class Manager : Employee
    {
        public void ManageTeam()
        {
             /* Implementacja */
        }
    }

    //```

    //Kroki do wykonania:

    //1. Usuń dziedziczenie w klasie Manager.
    //1. Utwórz interfejs IEmployee zawierający metody Work, AttendMeeting.
    //1. Wprowadź interfejs IEmployee do klasy Manager i przenieś do niej tylko te metody, które są używane.

    //Przykładowy docelowy kod wynikowy w pliku `RefusedBequest.cs`.


}
