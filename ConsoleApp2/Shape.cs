using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Shape
    {
        public abstract double Area();
        public String Color { get; set; }
        public Shape(String color)
        {
            Color = color;
        }
        public void ShowColor()
        {
            Console.WriteLine("Color of the shape is : " + Color);
        }
    }
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double rad, String color) : base(color)
        {
            Radius = rad;
        }
        public override double Area()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
    class Cylinder : Circle
    {
        public double Height { set; get; }
        public Cylinder(double rad, double height, String color) : base(rad, color)
        {
            this.Height = height;
        }
        public override double Area()
        {
            //double area = 2 * (Math.PI * radius * radius + Math.PI * radius *  height);
            double A = 2 * Math.PI * Radius * (Height + Radius);
            return A;
        }
    }
}
