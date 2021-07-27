using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        List<BaseObject> lst = new List<BaseObject>();
        int flag = 0; // circle = 0 //rect = 1// tri = 2// line = 3// hexa = 4
        BaseObject myObj = null;
        bool canDraw = false;
        Color color = Color.Black;
        bool undo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (myObj != null && canDraw || myObj != null && undo == true)
            {
                if (flag == 0)
                {
                    MyCircle l = (MyCircle)myObj;
                    if (FillCheckBox.Checked)
                    {
                        l.Fill = true;
                        e.Graphics.FillEllipse(new SolidBrush(l.Color),
                            l.StartPoint.X, l.StartPoint.Y,
                            l.Radius, l.Radius);
                    }

                    else
                    {
                        e.Graphics.DrawEllipse(new Pen(l.Color, 2),
                            l.StartPoint.X, l.StartPoint.Y,
                            l.Radius, l.Radius);
                    }
                }

                if (flag == 1)
                {
                    MyRectangle l = (MyRectangle)myObj;
                    if (FillCheckBox.Checked)
                    {
                        l.Fill = true;
                        e.Graphics.FillRectangle(new SolidBrush(l.Color), l.StartPoint.X,
                        l.StartPoint.Y, l.Width, l.Height);
                    }
                    else
                        e.Graphics.DrawRectangle(new Pen(l.Color, 2), l.StartPoint.X,
                            l.StartPoint.Y, l.Width, l.Height);
                }

                if (flag == 2)
                {
                    MyTriangle l = (MyTriangle)myObj;
                    if (FillCheckBox.Checked)
                    {
                        l.Fill = true;
                        e.Graphics.FillPolygon(new SolidBrush(l.Color), l.GetPoints());
                    }
                    else
                    {
                        e.Graphics.DrawPolygon(new Pen(l.Color,2), l.GetPoints());
                    }
                }

                if (flag == 3)
                {
                    MyLine l = (MyLine)myObj;
                    e.Graphics.DrawLine(new Pen(myObj.Color, 3),
                        l.StartPoint, l.LastPoint);
                }





                if (flag == 4)
                {
                    MyHexagon l = (MyHexagon)myObj;
                    if (FillCheckBox.Checked)
                    {
                        l.Fill = true;
                        e.Graphics.FillPolygon(new SolidBrush(l.Color), l.GetShape());
                    }
                    else
                    {
                        e.Graphics.DrawPolygon(new Pen(l.Color,2), l.GetShape());
                    }

                }

                foreach (var element in lst)
                {
                    if (element is MyCircle c)
                    {
                        if(c.Fill)
                        {
                            e.Graphics.FillEllipse(new SolidBrush(c.Color),
                             c.StartPoint.X, c.StartPoint.Y, c.Radius, c.Radius);
                        }
                        else
                        {
                            e.Graphics.DrawEllipse(new Pen(c.Color, 2), c.StartPoint.X,
                            c.StartPoint.Y,c.Radius, c.Radius);
                        }
                    }

                    if (element is MyRectangle r)
                    {
                        if (r.Fill)
                            e.Graphics.FillRectangle(new SolidBrush(r.Color), r.StartPoint.X,
                           r.StartPoint.Y, r.Width, r.Height);
                        else
                            e.Graphics.DrawRectangle(new Pen(r.Color, 2), r.StartPoint.X,
                                r.StartPoint.Y, r.Width, r.Height);
                    }

                    if (element is MyTriangle t)
                    {
                        if (t.Fill)
                            e.Graphics.FillPolygon(new SolidBrush(t.Color), t.GetPoints());
                        else
                            e.Graphics.DrawPolygon(new Pen(t.Color), t.GetPoints());
                    }

                    if (element is MyLine l)
                    {
                        e.Graphics.DrawLine(new Pen(l.Color, 3),
                        l.StartPoint, l.LastPoint);
                    }


                    if (element is MyHexagon h)
                    {
                        if (h.Fill)
                        {
                            e.Graphics.FillPolygon(new SolidBrush(h.Color), h.GetShape());
                        }

                        else
                        {
                            e.Graphics.DrawPolygon(new Pen(h.Color), h.GetShape());
                        }
                    }

                }
            }
            undo = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!canDraw) return;
            int x = Math.Min(myObj.StartPoint.X, e.X);
            int y = Math.Min(myObj.StartPoint.Y, e.Y);
            int width = Math.Max(myObj.StartPoint.X, e.X)
                - Math.Min(myObj.StartPoint.X, e.X);

            int height = Math.Max(myObj.StartPoint.Y, e.Y)
                 - Math.Min(myObj.StartPoint.Y, e.Y);
            switch (flag)
            {
                case 0:
                    MyCircle c = (MyCircle)myObj;
                    c.StartPoint = new Point(x, y);
                    c.Radius = width + height;
                    break;
                case 1:
                    MyRectangle r = (MyRectangle)myObj;
                    r.StartPoint = new Point(x, y);
                    r.Width = width;
                    r.Height = height;

                    break;
                case 2:
                    MyTriangle t= (MyTriangle)myObj;
                    t.StartPoint = new Point(x, y);
                    PointF p1 = t.StartPoint;
                    PointF p2 = new PointF(x+width,y);
                    PointF p3 = new PointF((width/2)+ x , y-height);
                    t.SetPoints(p1, p2, p3);
                    break;
                case 3:
                    ((MyLine)myObj).LastPoint = e.Location;
                    break;
                case 4:
                    MyHexagon h = (MyHexagon)myObj;
                    h.StartPoint = new Point(x, y);
                    PointF hp1 = new PointF(x,y+(height/2));
                    PointF hp2 = new PointF(x+(width/4),y);
                    PointF hp3 = new PointF(x + ((width / 4) * 3),y);
                    PointF hp4 = new PointF(x+width,y+height/2);
                    PointF hp5 = new PointF(x + ((width / 4) * 3),y + (height/4)*3);
                    PointF hp6 = new PointF(x+(width/4), y + (height / 4) * 3) ;
                    h.SetShape(hp1, hp2, hp3, hp4, hp5, hp6);

                    break;
            }

            Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;
            if(flag == 3)
            {
                ((MyLine)myObj).LastPoint = e.Location;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch(flag)
            {
                case 0:
                    myObj = new MyCircle();
                    break;
                case 1:
                    myObj = new MyRectangle();
                    break;
                case 2:
                    myObj = new MyTriangle();
                    break;
                case 3:
                    myObj = new MyLine();
                    break;
                case 4:
                    myObj = new MyHexagon();
                    break;
            }
            myObj.StartPoint = e.Location;
            myObj.Color = color;
            lst.Add(myObj);
            canDraw = true;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (lst.Count > 0)
                lst.RemoveAt(lst.Count - 1);
            undo = true;
            Refresh();
        }


        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            color = dlg.Color;
            ColorButton.BackColor = dlg.Color;
        }


        private void CircleButton_Click(object sender, EventArgs e)
        {
            flag = 0;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            flag = 3;
        }


        private void HexaButton_Click(object sender, EventArgs e)
        {
            flag = 4;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}