using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace List
{
    class MyCircle : BaseObject
    {
        public int Radius { get; set; }
        public bool Fill { get; set; }
        public MyCircle() { }
        public MyCircle(Point s,int r,Color c)
        {
            StartPoint = new Point();
            StartPoint = s;
            Radius = r;
            Color = c;
        }

    }
}
