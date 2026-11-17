using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsoportMunka_UrhajoSzimulacio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spacesuit moonsuit = new Spacesuit("moon_model", 100, 100);
            Console.WriteLine("Moon Suit");

            Spacesuit ckategorias = new Spacesuit("ckategorias_model", 60, 90);
            Console.WriteLine("C kategorias Model");

            Astronaut Gáspárlaci = new Astronaut("Gáspár Laci", 100, 80, 100, moonsuit);
            Astronaut Pápaijoci = new Astronaut("Pápai Joci", 80, 40, 70, ckategorias);

            Console.WriteLine("Pápai Joci");
            Console.WriteLine($" \t {Pápaijoci.Health} \n \t {Pápaijoci.Energy} \n \t {Pápaijoci.Oxygen} \n");

            Gáspárlaci.ShowGáspárlaciStatus();
            Pápaijoci.ShowPápaijociStatus();

            Gáspárlaci.Rest();
            Pápaijoci.Rest();

            Gáspárlaci.Work();
            Pápaijoci.Work();

            moonsuit.ShowmoonsuitStatus();
            ckategorias.ShowckategoriasStatus();

            List<Astronaut> astronautlist = new List<Astronaut>();
            astronautlist.Add(Pápaijoci);
            astronautlist.Add(Gáspárlaci);

            Spaceship gorillaz = new Spaceship(90, 80, 100, "gorillaz", astronautlist, "efficent", 3);

            Console.WriteLine(" ------GORILLAZ------");
            Console.WriteLine($" \t {gorillaz.Shield} \n \t {gorillaz.Hull} \n \t {gorillaz.Fuel} \n");

            gorillaz.Fuel = 60;
            gorillaz.Hull = 75;

            gorillaz.ShowStatus();

            gorillaz.Fuel = 90;

            gorillaz.Travel();
            gorillaz.Travel();

            gorillaz.Hull = 40;

            gorillaz.Reapir();

            gorillaz.TakeDamage();

            gorillaz.Fuel = 50;

            gorillaz.Travel();

            gorillaz.Fuel = 20;

            gorillaz.Travel();

            gorillaz.Fuel = 10;

            gorillaz.Travel();

            gorillaz.Hull = 20;

            gorillaz.Reapir();

            gorillaz.Hull = 50;

            gorillaz.Reapir();

            gorillaz.Hull = 80;

            gorillaz.Reapir();

            foreach (Astronaut astronauta in gorillaz.Astronautas)
            {
                astronauta.Showstatus();
            }
            gorillaz.ShowFullStatus();

            Console.WriteLine(Gáspárlaci.Energy);
            Gáspárlaci.Rest();
            Console.WriteLine(Gáspárlaci.Energy);


            Console.WriteLine(Pápaijoci.Energy);
            Gáspárlaci.Rest();
            Console.WriteLine(Pápaijoci.Energy);

            

        }
    }
    
}
