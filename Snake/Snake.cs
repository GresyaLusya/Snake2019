using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figures
    {
        Direction direction;

        public Snake(Point tail, int lenght, Direction direction)
        {
            plist = new List<Point>();
            this.direction = direction;
            for (int i = 0; i<lenght; i++)
            {             
                Point p = new Point(tail);
                p.Move(i, direction);                       
                plist.Add(p);
            }
        }

        public void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
           Point head = plist.Last(); 
           Point nextPoint = new Point(head);
           nextPoint.Move(1, direction); 
           return nextPoint;
        }
    }
}
