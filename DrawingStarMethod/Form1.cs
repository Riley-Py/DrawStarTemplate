using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            ///The following line of code demonstrates how to get input
            ///and convert it to a float value. Use this to help you in 
            ///Parts 2 - 4 where you need to get inputs from the 
            ///user and store them in float variables. This code is 
            ///not needed for Part 1.

            ///float size = Convert.ToSingle(sizeInput.Text); 
            
            Graphics g = this.CreateGraphics(); //for part 4 this gets moved to the custom methods.
            Pen blackPen = new Pen(Color.Black);

            //Starting from left point going counter-clockwise
            PointF point1 = new Point(0, 54);
            PointF point2 = new Point(32, 78);
            PointF point3 = new Point(20, 116);
            PointF point4 = new Point(51, 95);
            PointF point5 = new Point(85, 116);
            PointF point6 = new Point(74, 78);
            PointF point7 = new Point(107, 54);
            PointF point8 = new Point(65, 53);
            PointF point9 = new Point(50, 18);
            PointF point10 = new Point(40, 53);

            PointF[] star = {point1, point2, point3, point4, point5, point6, point7, point8, point9, point10};

            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {

        }

        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen()
            g.DrawPolygon()


        }

    }
}
