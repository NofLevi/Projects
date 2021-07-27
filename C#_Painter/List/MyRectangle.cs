using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace List
{
    
    class MyRectangle : BaseObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Fill { get; set; }
        public MyRectangle() { }
        public MyRectangle(int x,int y,int w,int h,Color c)
        {
            StartPoint = new Point(x, y);
            Width = w;
            Height = h;
            Color = c;
            
        }
    }
}
