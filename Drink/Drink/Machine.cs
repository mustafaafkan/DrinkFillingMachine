using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    class Machine
    {
        int Flow;
        public void openTap(int flow,Glass g)
        {
            Flow = flow;
            g.filltheGlass(flow);

        }
        public Machine(Glass gEvent)
        {
            gEvent.FillGlass += new Program.OnceGlassFilled(gotFilledGlass);
           
        }
        public void gotFilledGlass()
        {
            Flow = 0;
            Console.WriteLine("Closed The Tap");
        }

    }
}
