using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_to_the_exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            drawning l1 = new drawning(1,1);
            l1.draw_cube();
            l1.draw_player();
            Console.ReadKey();
        }
    }
}
