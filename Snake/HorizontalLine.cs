﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine :Figures
    {
       
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            list1 = new List<Point>();
            for(int i = xLeft; i < xRight; i++)
            {
                Point p1 = new Point(i, y, sym);
                list1.Add(p1);
            }
        }

    }
}
