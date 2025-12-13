using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Symulacja systemu tekstur  ---");

            TextureFactory textureFactory = new TextureFactory();
            List<GameObject> gameObjects = new List<GameObject>();

            
            Console.WriteLine("\n-- Tworzenie drzew --");
            gameObjects.Add(new GameObject("Drzewo_1", 10, 5, 0, textureFactory.GetTexture("Drzewo.png", 64, 128)));
            gameObjects.Add(new GameObject("Drzewo_2", 20, 10, 0, textureFactory.GetTexture("Drzewo.png", 64, 128)));
            gameObjects.Add(new GameObject("Drzewo_3", 30, 15, 0, textureFactory.GetTexture("Drzewo.png", 64, 128)));

            Console.WriteLine("\n-- Tworzenie skał --");
            gameObjects.Add(new GameObject("Skała_1", 5, 20, 0, textureFactory.GetTexture("Skała.png", 128, 128)));
            gameObjects.Add(new GameObject("Skała_2", 15, 25, 0, textureFactory.GetTexture("Skała.png", 128, 128)));

            Console.WriteLine("\n-- Tworzenie zamku --");
            gameObjects.Add(new GameObject("Zamek_Główny", 100, 100, 0, textureFactory.GetTexture("Zamek.png", 512, 512)));

            Console.WriteLine("\n-- Tworzenie trawy --");
            gameObjects.Add(new GameObject("Trawa_Pole_1", 0, 0, 0, textureFactory.GetTexture("Trawa.png", 32, 32)));
            gameObjects.Add(new GameObject("Trawa_Pole_2", 32, 0, 0, textureFactory.GetTexture("Trawa.png", 32, 32)));
            gameObjects.Add(new GameObject("Trawa_Pole_3", 64, 0, 0, textureFactory.GetTexture("Trawa.png", 32, 32)));


            Console.WriteLine("\n** Renderowanie obiektów gry **");
            foreach (var obj in gameObjects)
            {
                obj.Render();
            }

            
            Console.WriteLine("\n------");
            Console.WriteLine($"Stworzono {gameObjects.Count} obiektów gry.");
            Console.WriteLine($"Fabryka załadowała {textureFactory.GetNumberOfLoadedTextures()} unikalnych tekstur.");
            Console.WriteLine("\n-----");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
            Console.ReadKey();
        }
    }
}
