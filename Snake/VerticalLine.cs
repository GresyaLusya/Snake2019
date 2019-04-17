using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figures
    {


        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            list1 = new List<Point>();
            for (int i = yUp; i < yDown; i++)
            {
                Point p1 = new Point(x, i, sym);
                list1.Add(p1);
            }
        }

    }
}

