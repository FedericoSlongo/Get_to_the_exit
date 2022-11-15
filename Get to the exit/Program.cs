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
            while (true)
            {
                l1.draw_all();
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        if (l1.isValid(-1, 0))
                            l1.x_plyr--;
                        break;
                    case ConsoleKey.S:
                        if (l1.isValid(0, -1))
                            l1.y_plyr--;
                        break;
                    case ConsoleKey.D:
                        if (l1.isValid(1, 0))
                            l1.x_plyr++;
                        break;
                    case ConsoleKey.W:
                        if (l1.isValid(0, 1))
                            l1.x_plyr++;
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
