using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.Solutions_Mateusz_Behr
{
    public class Engine
    {
        public Cylinder GetCylinder()
        {
            return new Cylinder();
        }
    }

    public class Cylinder
    {
        public string GetSize()
        {
            return "2.0L";
        }
    }

    public class Car
    {
        public string GetCylinderSize()
        {
            Engine engine = new Engine();
            return engine.GetCylinder().GetSize();
        }
    }

    //Przykład wywołania
     Car car = new Car();
     string cylinderSize = car.GetCylinderSize();
}

//#### Message Chains (Łańcuchy wiadomości)

//Masz kod, który wywołuje łańcuch metod z Car.GeEngine().GetCylinder().GetSize(). Twoim zadaniem jest wprowadzenie nowej metody 
//    GetCylinderSize w klasie Car, aby zredukować łańcuch wiadomości.

//    Kod do refaktoryzacji:

//    csharp


// Przykład wywołania
//Car car = new Car();
//string cylinderSize = car.GetEngine().GetCylinder().GetSize();

//    ```

//Kroki do wykonania:

//1.Wprowadź metodę GetCylinderSize w klasie Car.
//1. Przenieś wywołanie zagnieżdżone do nowej metody w klasie Car.
//1. Zaktualizuj wywołania metod, aby używały nowej metody.

//    Przykładowy docelowy kod wynikowy w pliku `MessageChains.cs`.