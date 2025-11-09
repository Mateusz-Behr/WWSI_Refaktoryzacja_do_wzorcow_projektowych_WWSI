using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Prototype
{
    public class Ork
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Health { get; set; }
        public string Weapon { get; set; }
        public string SkinColor { get; set; }
        public string Tribe { get; set; }

 
        public Ork(string name, int strength, int health, string weapon, string skinColor, string tribe)
        {
            Name = name;
            Strength = strength;
            Health = health;
            Weapon = weapon;
            SkinColor = skinColor;
            Tribe = tribe;
        }


        public void DisplayOrkInfo()
        {
            Console.WriteLine($"Ork: {Name}");
            Console.WriteLine($"  Siła: {Strength}, Zdrowie: {Health}");
            Console.WriteLine($"  Broń: {Weapon}, Kolor skóry: {SkinColor}, Plemię: {Tribe}");
        }
    }
}
