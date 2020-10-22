using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SARK_Chat2
{
    class RoundedTextBox : TextBox
    {
        private CornerRadius CornerRadius { get; set; } = new CornerRadius(20);
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = RoundCornersPath(Rect, CornerRadius?.Radius ?? 20f))
            {
                Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.White, 1))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }

        }

        private static GraphicsPath RoundCornersPath(RectangleF rectangle, float radius)
        {
            float diameter;

            GraphicsPath path = new GraphicsPath();
            if (radius <= 0.0F)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();
                return path;
            }
            else
            {
                //Upper left corner.
                diameter = radius * 2.0F;

                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(rectangle.Location, sizeF);

                path.AddArc(arc, 180, 90);
                arc.X = rectangle.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = rectangle.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = rectangle.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();

                path.CloseFigure();
            }

            return path;
        }
    //}

    //public class CornerRadius
    //{
    //    float _radius;
    //    public float Radius
    //    {
    //        get { return _radius; }
    //        set
    //        {
    //            _radius = value;
    //            UpperLeft = _radius;
    //            UpperRight = _radius;
    //            BottomLeft = _radius;
    //            BottomRight = _radius;
    //        }
    //    }
    //    public float UpperLeft { get; set; }
    //    public float UpperRight { get; set; }
    //    public float BottomLeft { get; set; }
    //    public float BottomRight { get; set; }

    //    public CornerRadius(float radius)
    //    {
    //        Radius = radius;
    //    }
    }
}
