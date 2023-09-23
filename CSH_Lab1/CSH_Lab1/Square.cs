using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Square : Figure
{
    public double Side {  get; private set; }

    public Square(double side)
    {
        Side = side;
    }

   
    public override double calculatePerimeter() => Side * 4;
    public override double calculateArea() => Side * Side;
    public override string outputInfo() => "Квадрат со стороной " + Side.ToString();
}
