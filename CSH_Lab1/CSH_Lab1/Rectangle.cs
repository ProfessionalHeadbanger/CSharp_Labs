using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Figure
{
    private double Width;
    private double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetWidth()
    {
        return Width;
    }
    public double GetHeight()
    {
        return Height;
    }
    public void SetWidth(double width)
    {
        Width = width;
    }
    public void SetHeight(double height)
    {
        Height = height;
    }
    public override double calculatePerimeter() => Width * 2 + Height * 2;
    public override double calculateArea() => Width * Height;
}
