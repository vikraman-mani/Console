using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5,"RED");
            c1.Area();
            c1.ShowColor();
            Cylinder r = new Cylinder(2,5,"Yellow"); 
            r.Area();
            r.ShowColor();
        }
    }
}
