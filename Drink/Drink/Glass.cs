using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    

    class Glass
    {
        public event Program.OnceGlassFilled FillGlass;
        int capacity=20;
        int amount = 0;

        public void filltheGlass(int flow)
        {
            for(int i=0;i<=capacity;i++)
            {
                if ((amount+flow <= capacity) && flow > 0)
                {
                    amount += flow;
                    Console.WriteLine(amount.ToString());
                }
                else
                {
                    Console.WriteLine("the glass got filled");
                    FillGlass();
                    return;
                }
                    

            }
        }

    }
}
