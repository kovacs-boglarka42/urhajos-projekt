using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsoportMunka_UrhajoSzimulacio
{
    internal class Spacesuit
    {
        public string Model;
        public int OxygenLevel;
        public int Integrity;

        public Spacesuit(string model, int oxygenlevel, int integrity)

        {
            Model = model;
            OxygenLevel = oxygenlevel;
            Integrity = integrity;
        }

        public void ShowmoonsuitStatus()
        {
            Console.WriteLine("Moon Suit");
            Console.WriteLine($" \t {Model} \n \t {OxygenLevel} \n \t {Integrity} \n");
        }

        public void ShowckategoriasStatus()
        {
            Console.WriteLine("C kategorias Model");
            Console.WriteLine($" \t {Model} \n \t {OxygenLevel} \n \t {Integrity} \n");
        }


    }
}
