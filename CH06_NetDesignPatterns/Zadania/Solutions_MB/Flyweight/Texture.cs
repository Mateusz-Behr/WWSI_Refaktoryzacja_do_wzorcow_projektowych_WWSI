using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Flyweight
{
    public class Texture
    {
        public string Name { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        private string _pixelData;

        public Texture(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
            _pixelData = $"Dane pikseli dla {name} ({width}x{height})";
            Console.WriteLine($"[Texture] Ładuję teksturę z pliku: {name} (kosztowna operacja)");
        }

        public void Display()
        {
            Console.WriteLine($"  - Tekstura: {Name} ({Width}x{Height}");
        }
    }
}
