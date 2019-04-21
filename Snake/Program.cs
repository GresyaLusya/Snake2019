using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.SetWindowSize(80, 25);
             Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
         
            HorizontalLine h1 = new HorizontalLine(1, 80, 1, '*');
            HorizontalLine h2 = new HorizontalLine(1, 80, 24, '*');
            VerticalLine v1 = new VerticalLine(1, 24, 1, '*');
            VerticalLine v2 = new VerticalLine(1, 24, 79, '*');
            h1.Draw();
            h2.Draw();
            v1.Draw();
            v2.Draw();


            Point p1 = new Point(7, 7, '*');

            Snake snake = new Snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();



            Console.ReadLine();
        }
    }
}
