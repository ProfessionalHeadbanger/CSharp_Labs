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
            bool is_empty = false;
            if (labelWidth.Visible && labelHeight.Visible)
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    is_empty = true;
                }
                else
                {
                    var shape = new global::Rectangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawRectangle(Pens.Black, 200, 150, ((float)shape.GetWidth()) * 50, ((float)shape.GetHeight()) * 50);
                }
            }
            if (labelSide.Visible)
            {
                if (textBox1.Text == "")
                {
                    is_empty = true;
                }
                else
                {
                    var shape = new Square(double.Parse(textBox1.Text));
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawRectangle(Pens.Black, 200, 150, ((float)shape.GetSide()) * 50, ((float)shape.GetSide()) * 50);
                }
            }
            if (labelRadius.Visible)
            {
                if (textBox1.Text == "")
                {
                    is_empty = true;
                }
                else
                {
                    var shape = new Circle(double.Parse(textBox1.Text));
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawEllipse(Pens.Black, 200, 150, ((float)shape.GetRadius()) * 50, ((float)shape.GetRadius()) * 50);
                }
            }
            if (labelSideAB.Visible && labelSideBC.Visible && labelSideCA.Visible)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    is_empty = true;
                }
                else
                {
                    var shape = new Triangle(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                    if (shape.GetSideAB() < shape.GetSideBC() + shape.GetSideCA()
                        && shape.GetSideBC() < shape.GetSideAB() + shape.GetSideCA()
                        && shape.GetSideCA() < shape.GetSideAB() + shape.GetSideBC())
                    {
                        labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                        labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                        double angleB = Math.Acos((shape.GetSideAB() * shape.GetSideAB() + shape.GetSideBC() * shape.GetSideBC() - shape.GetSideCA() * shape.GetSideCA())
                            / (2 * shape.GetSideAB() * shape.GetSideAB()));
                        var point1 = new Point(200, 150);
                        var point2 = new Point(200 + (int)shape.GetSideAB() * 20, 150);
                        var point3 = new Point((int)(200 + shape.GetSideAB() * 20 * Math.Cos(angleB)), (int)(150 + shape.GetSideAB() * 20 * Math.Sin(angleB)));
                        g.Clear(Color.Azure);
                        g.DrawLines(Pens.Black, new[] { point1, point2, point3, point1 });
                    }
                    else
                    {
                        MessageBox.Show("Такого треугольника не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (is_empty)
            {
                MessageBox.Show("Вы не ввели данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
