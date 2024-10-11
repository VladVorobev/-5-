using System;
using System.Drawing;
using System.Windows.Forms;

namespace модуль_5_воробьёв
{
    public partial class DrawingAppForm : Form
    {
        private enum Shape { None, Line, Circle, Rectangle }
        private Shape currentShape = Shape.None;

        private Point startPoint;
        private bool drawing = false;

        public DrawingAppForm()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Line;
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Circle;
        }

        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            currentShape = Shape.Rectangle;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            canvas.Invalidate(); // очищаем холст, перерисовывая его
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape != Shape.None)
            {
                startPoint = e.Location;
                drawing = true;
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                using (Graphics g = canvas.CreateGraphics())
                {
                    Pen pen = new Pen(Color.Black, 2);

                    switch (currentShape)
                    {
                        case Shape.Line:
                            g.DrawLine(pen, startPoint, e.Location);
                            break;

                        case Shape.Circle:
                            int radius = Math.Min(Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
                            g.DrawEllipse(pen, startPoint.X - radius, startPoint.Y - radius, 2 * radius, 2 * radius);
                            break;

                        case Shape.Rectangle:
                            g.DrawRectangle(pen, Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y),
                                Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
                            break;
                    }
                }

                drawing = false;
                currentShape = Shape.None;
            }
        }
    }
}
