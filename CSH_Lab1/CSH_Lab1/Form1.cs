using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Graphics g;
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            labelSide.Visible = false;
            labelRadius.Visible = false;
            labelSideAB.Visible = false;
            labelSideBC.Visible = false;
            labelSideCA.Visible = false;

            textBox3.Visible = false;

            labelWidth.Visible = true;
            labelHeight.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            labelWidth.Visible = false;
            labelHeight.Visible = false;
            labelRadius.Visible = false;
            labelSideAB.Visible = false;
            labelSideBC.Visible = false;
            labelSideCA.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;

            labelSide.Visible = true;

            textBox1.Visible = true;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            labelWidth.Visible = false;
            labelHeight.Visible = false;
            labelSide.Visible = false;
            labelSideAB.Visible = false;
            labelSideBC.Visible = false;
            labelSideCA.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;

            labelRadius.Visible = true;

            textBox1.Visible = true;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            labelWidth.Visible = false;
            labelHeight.Visible = false;
            labelSide.Visible = false;
            labelRadius.Visible = false;

            labelSideAB.Visible = true;
            labelSideBC.Visible = true;
            labelSideCA.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            if (labelWidth.Visible && labelHeight.Visible)
            {
                var shape = new Rectangle { Width = double.Parse(textBox1.Text), Height = double.Parse(textBox2.Text) };
                labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                g.Clear(Color.Azure);
                g.DrawRectangle(Pens.Black, 200, 150, ((float)shape.Width)*50, ((float)shape.Height)*50);
            }
            if (labelSide.Visible)
            {
                var shape = new Square { Side = double.Parse(textBox1.Text) };
                labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                g.Clear(Color.Azure);
                g.DrawRectangle(Pens.Black, 200, 150, ((float)shape.Side) * 50, ((float)shape.Side) * 50);
            }
            if (labelRadius.Visible)
            {
                var shape = new Circle { Radius = double.Parse(textBox1.Text) };
                labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                g.Clear(Color.Azure);
                g.DrawEllipse(Pens.Black, 200, 150, ((float)shape.Radius) * 50, ((float)shape.Radius) * 50);
            }
            if (labelSideAB.Visible && labelSideBC.Visible &&  labelSideCA.Visible)
            {
                var shape = new Triangle
                {
                    SideAB = double.Parse(textBox1.Text),
                    SideBC = double.Parse(textBox2.Text),
                    SideCA = double.Parse(textBox3.Text)
                };
                labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                double angleB = Math.Acos((shape.SideAB * shape.SideAB + shape.SideBC * shape.SideBC - shape.SideCA * shape.SideCA)/(2*shape.SideAB*shape.SideBC));
                var point1 = new Point(200, 150);
                var point2 = new Point(200 + (int)shape.SideAB*20, 150);
                var point3 = new Point((int)(200 + shape.SideAB*20*Math.Cos(angleB)), (int)(150 + shape.SideAB * 20 *Math.Sin(angleB)));
                g.Clear(Color.Azure);
                g.DrawLines(Pens.Black, new[] { point1, point2, point3, point1 });
            }
            
        }
    }
}
