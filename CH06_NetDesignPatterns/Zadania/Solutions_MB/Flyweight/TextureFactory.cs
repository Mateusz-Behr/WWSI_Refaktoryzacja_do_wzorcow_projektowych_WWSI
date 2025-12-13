using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Flyweight
{
    public class TextureFactory
    {
        private Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        public Texture GetTexture(string name, int width, int height)
        {
            if (_textures.ContainsKey(name))
            {
                Console.WriteLine($"[TextureFactory] Zwracam współdzieloną teksturę: {name}");
                return _textures[name];
            }
            else
            {
                Console.WriteLine($"[TextureFactory] Tworzę nową teksturę i dodaję do puli: {name}");
                Texture newTexture = new Texture(name, width, height);
                _textures.Add(name, newTexture);
                return newTexture;
            }
        }

        public int GetNumberOfLoadedTextures()
        {
            return _textures.Count;
        }
    }
}
