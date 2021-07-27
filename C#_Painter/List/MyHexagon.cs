using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyHexagon : BaseObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Fill { get; set; }
        public int Radius { get; set; } //radius
        PointF[] shape = new PointF[6];


        public MyHexagon() { }
        public MyHexagon(int x, int y, int w, int h,bool _fill)
        {
            Fill = _fill;
            StartPoint = new Point(x, y);
            Width = w;
            Height = h;
        }

        public void SetShape(PointF p1, PointF p2, PointF p3, PointF p4, PointF p5, PointF p6)
        {
            shape[0] = p1;
            shape[1] = p2;
            shape[2] = p3;
            shape[3] = p4;
            shape[4] = p5;
            shape[5] = p6;
        }
        public PointF[] GetShape()
        {
            return shape;
        }
    }
}
