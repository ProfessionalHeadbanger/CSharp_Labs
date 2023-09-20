using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Triangle : Figure
{
    private double SideAB;
    private double SideBC;
    private double SideCA;

    public Triangle(double sideAB, double sideBC, double sideCA)
    {
        SideAB = sideAB;
        SideBC = sideBC;
        SideCA = sideCA;
    }

    public void SetSideAB(double sideAB)
    {
        SideAB = sideAB;
    }
    public void SetSideBC(double sideBC)
    {
        SideBC = sideBC;
    }
    public void SetSideCA(double sideCA)
    {
        SideCA = sideCA;
    }
    public double GetSideAB()
    {
        return SideAB;
    }
    public double GetSideBC()
    {
        return SideBC;
    }
    public double GetSideCA()
    {
        return SideCA;
    }

    public override double calculatePerimeter() => SideAB + SideBC + SideCA;
    public override double calculateArea() => Math.Sqrt(((SideAB + SideBC + SideCA) / 2) *
        (((SideAB + SideBC + SideCA) / 2) - SideAB) *
        (((SideAB + SideBC + SideCA) / 2) - SideBC) *
        (((SideAB + SideBC + SideCA) / 2) - SideCA));
}
