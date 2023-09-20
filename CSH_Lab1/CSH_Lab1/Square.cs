using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Square : Figure
{
    private double Side;

    public Square(double side)
    {
        Side = side;
    }

    public double GetSide()
    {
        return Side;
    }
    public void SetSide(double side)
    {
        Side = side;
    }
    public override double calculatePerimeter() => Side * 4;
    public override double calculateArea() => Side * Side;
}
