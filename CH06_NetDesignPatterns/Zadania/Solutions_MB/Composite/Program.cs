using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Symulacja menu restauracji ze wzorcem kompozyt. ---");
            Console.WriteLine("-----");

            MenuCategory mainMenu = new MenuCategory("Główne menu restauracji", "Nasza oferta kulinarna");

            MenuCategory appetizers = new MenuCategory("Przystawki", "Rozgrzewka przed daniem głównym");
            MenuCategory mainCourses = new MenuCategory("Dania główne", "Gwóźdź programu");
            MenuCategory desserts = new MenuCategory("Desery", "Słodkie zakończenie");
            MenuCategory drinks = new MenuCategory("Napoje", "Coś do picia");

            mainMenu.Add(appetizers);
            mainMenu.Add(mainCourses);
            mainMenu.Add(desserts);
            mainMenu.Add(drinks);


            appetizers.Add(new MenuItem("Bruschetta", "Grzanki z pomidorami i bazylią", 18.00));
            appetizers.Add(new MenuItem("Tatar Wołowy", "Świeży tatar z kaparami i ogórkiem", 35.00));


            mainCourses.Add(new MenuItem("Stek z Polędwicy", "250g polędwicy wołowej, sos pieprzowy", 75.00));
            mainCourses.Add(new MenuItem("Łosoś Pieczony", "Łosoś z warzywami, puree ziemniaczane", 60.00));


            MenuCategory vegetarianMainCourses = new MenuCategory("Dania Główne Wegetariańskie", "Smakowite opcje bez mięsa");

            mainCourses.Add(vegetarianMainCourses);
            vegetarianMainCourses.Add(new MenuItem("Risotto z Grzybami", "Kremowe risotto z leśnymi grzybami", 48.00));
            vegetarianMainCourses.Add(new MenuItem("Burger Warzywny", "Burger z grillowanymi warzywami i sosem aioli", 45.00));


            desserts.Add(new MenuItem("Sernik Nowojorski", "Klasyczny sernik z sosem malinowym", 22.00));
            desserts.Add(new MenuItem("Lody Waniliowe", "Trzy gałki lodów waniliowych", 15.00));


            drinks.Add(new MenuItem("Woda Mineralna", "Gazowana lub niegazowana", 8.00));
            drinks.Add(new MenuItem("Sok Pomarańczowy", "Świeżo wyciskany", 12.00));


            Console.WriteLine("--- Menu restauracji ---");
            mainMenu.Display();
            Console.WriteLine("-----");

            Console.WriteLine("--- Przystawki ---");
            appetizers.Display();
            Console.WriteLine("-----");

            Console.WriteLine("\n--- Koniec symulacji menu ---");
            Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć...");
            Console.ReadKey();
        }
    }
}
