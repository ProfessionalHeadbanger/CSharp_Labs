using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : Figure
{
    private double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void SetRadius(double radius)
    {
        Radius = radius;
    }
    public double GetRadius()
    {
        return Radius;
    }
    public override double calculatePerimeter() => 2 * 3.14 * Radius;
    public override double calculateArea() => 3.14 * Radius * Radius;
}