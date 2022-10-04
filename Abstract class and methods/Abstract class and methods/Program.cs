using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_and_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Triangle shape = new Triangle();
            shape.b=3;
            shape.h = 5;
            shape.area();

           Circle shape1 = new Circle();
            shape1.r = 4;
            shape1.area();

            squre shape2 = new squre();
            shape2.a = 6;
            shape2.area();
        }
    }
}
