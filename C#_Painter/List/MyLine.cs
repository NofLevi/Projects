using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace List
{
    class MyLine : BaseObject
    {
       public  Point LastPoint { get; set; }
        public MyLine() { }
        public MyLine(Point p1, Point p2,Color c)
        {
            StartPoint = p1;
            LastPoint = p2;
            Color = c;
        }

    }
}
