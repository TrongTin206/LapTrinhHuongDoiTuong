using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lab5_5
{
    public partial class Form1 : Form
    {
        int startX;
        int startY;

        List<Shape> list = new List<Shape>();
        private object panel1Draw;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Graphics graphics = panelDraw.CreateGraphics();

            //Rectangle rectangle = new Rectangle(20, 10, 100, 200);
            //Pen pen = new Pen(Color.Blue);

            //graphics.DrawRectangle(pen, rectangle);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                list.Add(new ShapeRectangle(
                    Math.Min(startX, e.X),
                    Math.Min(startY, e.Y),
                    Math.Abs(e.X - startX),
                    Math.Abs(e.Y - startY)));
            }
            if (radioButton2.Checked)
            {
                list.Add(new ShapeEllipse(
                    Math.Min(startX, e.X),
                    Math.Min(startY, e.Y),
                    Math.Abs(e.X - startX),
                    Math.Abs(e.Y - startY)));
            }
            panel1.Refresh();

            Graphics graphics = panel1.CreateGraphics();
            DrawAllShape(graphics);
        }
        private void DrawAllShape(Graphics graphics)
        {
            double maxArea = list.Max(p => p.Area());
            Pen pen = new Pen(Color.Blue);

            foreach (Shape shape in list)
            {
                if (shape is ShapeRectangle shapeRec)
                {
                    Rectangle rectangle = new Rectangle(
                        shapeRec.X,
                        shapeRec.Y,
                        shapeRec.Width,
                        shapeRec.Height
                    );
                    if (shape.Area() == maxArea)
                    {
                        Brush brush = new SolidBrush(Color.Pink);
                        graphics.FillRectangle(brush, rectangle);
                    }
                    graphics.DrawRectangle(pen, rectangle);
                }

                if (shape is ShapeEllipse shapeElip)
                {
                    Rectangle rectangle = new Rectangle(
                        shapeElip.X,
                        shapeElip.Y,
                        shapeElip.Width,
                        shapeElip.Height
                    );
                    if (shape.Area() == maxArea)
                    {
                        Brush brush = new SolidBrush(Color.Green);
                        graphics.FillEllipse(brush, rectangle);
                    }
                    graphics.DrawEllipse(pen, rectangle);
                }
            }
        }
    }
}

