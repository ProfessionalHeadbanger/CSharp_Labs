using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Figure
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double calculatePerimeter() => Width * 2 + Height * 2;
    public override double calculateArea() => Width * Height;
    public override string outputInfo() => "Прямоугольник со сторонами " + Width.ToString() 
        + " и " + Height.ToString();
}
