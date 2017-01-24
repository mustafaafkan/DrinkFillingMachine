using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    class Program
    {
        public delegate void OnceGlassFilled();
        static void Main(string[] args)
        {
            Console.WriteLine("please, enter the flow speed");
            int flow = int.Parse(Console.ReadLine());
            Glass g1 = new Glass();
            Machine m1 = new Machine(g1);
            m1.openTap(flow, g1);
            Console.ReadLine();
        }
    }
}
