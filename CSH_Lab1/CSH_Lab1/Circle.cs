using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : Figure
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double calculatePerimeter() => 2 * 3.14 * Radius;
    public override double calculateArea() => 3.14 * Radius * Radius;
    public override string outputInfo() => "Круг с радиусом " + Radius.ToString();
}