using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figures
    {
        protected List<Point> list1;

        public void Draw()
        {
            foreach (Point p in list1) p.Draw();
        }

    }
}
