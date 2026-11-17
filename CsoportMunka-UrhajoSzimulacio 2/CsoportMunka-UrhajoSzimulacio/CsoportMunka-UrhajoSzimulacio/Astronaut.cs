using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsoportMunka_UrhajoSzimulacio
{
    internal class Astronaut
    {
        public string Name { get; set; }
        public int Health;
        public int Energy { get; private set; }
        public int Oxygen;
        public Spacesuit Suit;
        public Astronaut(string name, int health, int energy, int oxygen, Spacesuit suit)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Oxygen = oxygen;
            Suit = suit;
        }

        public void Rest()
        {
            Energy += 30;
            Console.WriteLine("Az urhajos pihen");
        }

        public void Work()
        {
            Energy -= 20;
            Oxygen -= 10;
            Console.WriteLine("Az urhajos dolgozik");
        }

        public void ShowGáspárlaciStatus()
        {
            Console.WriteLine("Gáspár Laci");
            Console.WriteLine($" \t {Health} \n \t {Energy} \n \t {Oxygen} \n");
        }
        public void ShowPápaijociStatus()
        {
            Console.WriteLine("Pápai Joci");
            Console.WriteLine($" \t {Health} \n \t {Energy} \n \t {Oxygen} \n");
        }

        public void Showstatus()
        {
            Console.WriteLine($"{Name} \n név: {Name} \n Élet: {Health} \n Energia: {Energy} \n Oxigen: {Oxygen} \n \n ");
        }
    }
}
