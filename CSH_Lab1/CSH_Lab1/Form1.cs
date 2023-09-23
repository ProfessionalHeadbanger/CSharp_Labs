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
        MyLinkedList<Figure> figures = new MyLinkedList<Figure>();
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
                    figures.AddToHead(shape);
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawRectangle(Pens.Black, 200, 150, (float)shape.Width * 50, (float)shape.Height * 50);
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
                    figures.AddToHead(shape);
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawRectangle(Pens.Black, 200, 150, ((float)shape.Side) * 50, ((float)shape.Side) * 50);
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
                    figures.AddToHead(shape);
                    labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                    labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                    g.Clear(Color.Azure);
                    g.DrawEllipse(Pens.Black, 200, 150, (float)shape.Radius * 50, (float)shape.Radius * 50);
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
                    if (shape.SideAB < shape.SideBC + shape.SideCA
                        && shape.SideBC < shape.SideAB + shape.SideCA
                        && shape.SideCA < shape.SideAB + shape.SideBC)
                    {
                        figures.AddToHead(shape);
                        labelPerimeter.Text = "Периметр: " + Convert.ToString(shape.calculatePerimeter());
                        labelArea.Text = "Площадь: " + Convert.ToString(shape.calculateArea());
                        double angleB = Math.Acos((shape.SideAB * shape.SideAB + shape.SideBC * shape.SideBC - shape.SideCA * shape.SideCA)
                            / (2 * shape.SideAB * shape.SideAB));
                        var point1 = new Point(200, 150);
                        var point2 = new Point(200 + (int)shape.SideAB * 20, 150);
                        var point3 = new Point((int)(200 + shape.SideAB * 20 * Math.Cos(angleB)), (int)(150 + shape.SideAB * 20 * Math.Sin(angleB)));
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

        private void ListButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Random rnd = new Random();
            MyLinkedList<int> list = new MyLinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.AddToHead(rnd.Next(1, 1000));
            }
            string output = "";
            foreach(var i in list)
            {
                output += i.ToString() + '\n';
            }
            richTextBox1.Text = output;
        }

        private void ListButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Random rnd = new Random();
            int strlenght = rnd.Next(5, 10);
            MyLinkedList<string> list = new MyLinkedList<string>();
            for (int i = 0; i < 10; i++)
            {
                string str = "";
                for (int j = 0; j < strlenght; j++)
                {
                    str += Convert.ToChar(rnd.Next(0, 26) + 65);
                }
                list.AddToHead(str);
            }
            string output = "";
            foreach(var i in list)
            {
                output += i + '\n';
            }
            richTextBox1.Text = output;
        }

        private void ListButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string output = "";
            foreach (var i in figures)
            {
                output += i.outputInfo() + '\n';
            }
            richTextBox1.Text = output;
        }
    }
}
