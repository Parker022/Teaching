using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFirstProgram
{
    public abstract class Animal
    {
        public string name;
        public int ammountOfLegs;

        public abstract void MakeANoise();
    }

    public class Tiger : Animal 
    {
        public bool stripes = true;

        public Tiger() 
        {
            name = "Tiger";
            ammountOfLegs = 4;
        }

        public override void MakeANoise()
        {
            Console.WriteLine("RAWR");
        }
    }

    public class Kangaroo : Animal
    {
        public Kangaroo()
        {
            name = "Kangroo";
            ammountOfLegs = 4;
        }

        public override void MakeANoise()
        {
            Console.WriteLine("UGH");
        }

        public void Jump()
        {
            Console.WriteLine("BOUNCE!");
        }
    }
}
