using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_and_methods
{
    public abstract class Shape
    {
        public abstract void area();

    }
    public class Triangle : Shape
    {
        public double b;
        public double h;
        public override void area()
        {
            double Area = 0.5 * b * h;
            Console.WriteLine("area of triangle" + Area);
        }
    }
    public class Circle : Shape
    {
        public double pi = 3.14;
        public double r;
        public override void area()
        {
            double Area = pi * (r * r);
            Console.WriteLine("area of Circle" + Area);
        }
    }
    public class squre : Shape
    {
        public double a;
        public override void area()
        {
            double Area = a * a;
            Console.WriteLine("area of Squre" + Area);
        }
    }
}
