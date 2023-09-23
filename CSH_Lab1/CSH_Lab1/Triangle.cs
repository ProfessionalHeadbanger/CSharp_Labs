using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : Figure
{
    public double SideAB { get; private set; }
    public double SideBC { get; private set; }
    public double SideCA { get; private set; }

    public Triangle(double sideAB, double sideBC, double sideCA)
    {
        SideAB = sideAB;
        SideBC = sideBC;
        SideCA = sideCA;
    }

    public override double calculatePerimeter() => SideAB + SideBC + SideCA;
    public override double calculateArea() => Math.Sqrt(((SideAB + SideBC + SideCA) / 2) *
        (((SideAB + SideBC + SideCA) / 2) - SideAB) *
        (((SideAB + SideBC + SideCA) / 2) - SideBC) *
        (((SideAB + SideBC + SideCA) / 2) - SideCA));
    public override string outputInfo() => "Треугольник со сторонами " + SideAB.ToString()
        + ", " + SideBC.ToString() + " и " + SideCA.ToString();
}
