using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsoportMunka_UrhajoSzimulacio
{
    internal class Spaceship
    {
        public List<Astronaut> Astronautas;
        public int a;
        public int Fuel;
        public double Shield;
        public double Hull;
        public string EngineType
        {
            get;
        }
        public int FuelNeed;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        private string name;
        
        public int CrewCount
        {
            get
            {
                return Astronautas.Count;
            }
        }

        public Spaceship(int fuel, double shield, double hill, string name, List<Astronaut> astroanutas, string enginetype, int fuelneed)

        {
            Fuel = fuel;
            Shield = shield;
            Hull = hill;
            Name = name;
            Astronautas = astroanutas;
            EngineType = enginetype;
            FuelNeed = fuelneed;
        }

        public void ShowStatus()
        {
            Console.WriteLine(" ------GORILLAZ------");
            Console.WriteLine($" \t {Shield} \n \t {Hull} \n \t {Fuel} \n");
        }

        public void Travel(int distance)
        {
            if (Fuel >= 20)
            {
                Fuel = Fuel - 20;
                Console.WriteLine($"A Hajo utazik \n -Változott érték Fuel: {Fuel}- \n");
            }
            else { Console.WriteLine($"Nincs elég üzemanyag az utazáshoz. \n"); }
        }

        public void Reapir()
        {
            if (Hull < 30)
            {
                Hull += 40;
                Console.WriteLine("Kritikus javitás folyamatban \n");
            }
            else if (Hull < 70 && Hull > 30)
            {
                Hull += 25;
                Console.WriteLine("Normál javítás folyamatban");
            }
            else { Console.WriteLine("nincs szügség javitásra"); }

        }

        public void TakeDamage()
        {
            Shield -= 30;
            Hull -= 20;

            Console.WriteLine($" Talalat erte a hajot! \n Valtozott ertek Shield: {Shield}\n \t \t   Hull: {Hull} \n ");
        }
        public void ShowFullStatus()
        {
            Console.WriteLine($"{Name} \n Hull: {Hull} \n pajzs: {Shield} \n");

            foreach (Astronaut astroanuta in Astronautas)
            {
                a = a + 1;
            }
            Console.WriteLine($"Legénység száma: {a} \n \n");
            foreach (Astronaut astroanuta1 in Astronautas)
            {
                astroanuta1.Showstatus();
            }
        }
        public bool CantTravel(int distance)
        {
            int fuelneeded = (distance / 5) * FuelNeed;
            if(EngineType == "efficent")
            {
                fuelneeded = fuelneeded / 2;
            }
            if(fuelneeded >= Fuel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}