using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList1;
        public VerticalLine(int yLeft, int yright, int x, char sym)
        {
            pList1 = new List<Point>();
            for(int y = yLeft; y<=yright; y++)
            {
                Point p = new Point(x, y, sym);
                pList1.Add(p);
            }

            
        }
        public void Drow1()
        {
            foreach (Point p in pList1)
            {
                p.Draw();
            }
        }

    }
}
