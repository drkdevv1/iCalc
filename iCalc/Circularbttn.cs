using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace iCalc
{
    class Circularbttn : Button
    {
        public Circularbttn()
        {
            // Desactiva el efecto de enfoque al hacer clic
            this.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            int radius = Math.Min(rectSurface.Width, rectSurface.Height) / 2;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, radius))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 0))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // Button surface
                this.Region = new Region(pathSurface);
                // Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);
            }

        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect.X, rect.Y, radius * 2, radius * 2);
            return path;
        }
    }
}
