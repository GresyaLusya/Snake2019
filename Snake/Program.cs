using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.SetWindowSize(80, 25);
             Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
         


            Point p1 = new Point(1, 1, '*');
            p1.Draw();

            HorizontalLine h1 = new HorizontalLine(1, 80, 1, '*');
            HorizontalLine h2 = new HorizontalLine(1, 80, 24, '*');
            VerticalLine v1 = new VerticalLine(1, 24, 1, '*');
            VerticalLine v2 = new VerticalLine(1, 24, 79, '*');
            h1.Draw();
            h2.Draw();
            v1.Draw();
            v2.Draw();



            Console.ReadLine();
        }
    }
}
