using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintballGame
{
    class Paintball
    {
        List<Point> shots = new List<Point>();


        public void paint(Graphics g, int x, int y)
        { 
            g.FillEllipse(Brushes.DarkGreen, x, y, 20, 20);
        }

    }
}
