using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Flyweight
{
    public class GameObject
    {
        private string _id;
        private int _x, _y, _z;
        private Texture _texture;

        public GameObject(string id, int x, int y, int z, Texture texture)
        {
            _id = id;
            _x = x;
            _y = y;
            _z = z;
            _texture = texture;

            Console.WriteLine($"[GameObject] Tworzę obiekt: {_id} w ({_x},{_y},{_z}) z teksturą {_texture.Name}");
        }

        public void Render()
        {
            Console.WriteLine($"[GameObject] Renderuję obiekt: {_id} na pozycji {_x},{_y},{_z})");
            _texture.Display();
        }
    }
}
