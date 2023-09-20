using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

abstract class Figure
{
    public abstract double calculatePerimeter();
    public abstract double calculateArea();
}

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
    public override double calculatePerimeter() => Width*2 + Height*2;
    public override double calculateArea() => Width * Height;
}

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

namespace CSH_Lab1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
