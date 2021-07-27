using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyTriangle : BaseObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Fill { get; set; }
        PointF[] points = new PointF[3];
        public MyTriangle() { }
        public MyTriangle(int x, int y, int w, int h, Color c)
        {
            StartPoint = new Point(x, y);
            Width = w;
            Height = h;
            Color = c;
        }
        
        public void SetPoints(PointF p1,PointF p2,PointF p3)
        {
            points[0] = p1;
            points[1] = p2;
            points[2] = p3;
        }

        public PointF[] GetPoints()
        {
            return points;
        }
    }
}
