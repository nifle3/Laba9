using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    interface Ifigurable
    {
        public abstract void Draw();
        public bool MoveTo(double deltax, double deltay);
    }

    internal abstract class SimpleFigure : Ifigurable
    {
        private double _x;
        private double _y;
        private double _width;
        private double _height;
        
        public string Name { set; get; }

        public SimpleFigure(double x, double y, double width, double height, string name) =>
           (Width, Height, X, Y, name) = (width, height, x, y, Name);

        public abstract void Draw();

        public bool MoveTo(double deltax, double deltay)
        {
            double sidex = _x + _width;
            double sidey = _y + _height;

            double pBWidth = Init.picturebox.Width;
            double pBHeight = Init.picturebox.Height;

            if (sidex + deltax <= pBWidth && _x + deltax >= 0 && sidey + deltay <= pBHeight && _y + deltay >= 0)
            {
                _x += deltax;
                _y += deltay;
                return true;
            }

            return false;
        }

        public double X { set { _x = value >= 0 ? value : 0; } get => _x; }
        public double Y { set { _y = value >= 0 ? value : 0; } get => _y; }
        public double Width { set { _width = value >= 0 ? value : 1; } get => _width; }
        public double Height { set { _height = value >= 0 ? value : 1; } get => _height; }
    }

    internal class Figure : SimpleFigure
    {
        public Figure(double x, double y, double wid, double hei, string name) : base(x, y, wid, hei, name) { }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);

            g.DrawRectangle(Init.pen, (int)X, (int)(Y + (Height / 2)), (int)Width, (int)Height / 2);
            g.DrawEllipse(Init.pen, (int)X, (int)(Y + Height / 2), (int)Width, (int)Height / 2);
            g.DrawPolygon(Init.pen, new Point[]{
                new Point((int)(X + Width/2), (int)Y),
                new Point((int)X, (int)(Y + Height/2)),
                new Point((int)(X + Width), (int)(Y + Height/2))
            });

            Init.picturebox.Image = Init.bitmap;
        }
    }
}
