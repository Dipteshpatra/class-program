using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_program
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.carid = 201;
            car1.CarNAME = "ford";
            car1.Colour = "Black";
            car1.Maxspeed = 150;
            car1.type();
            car1.warning();
            Console.WriteLine("Car id\t" + car1.carid);
            Console.WriteLine("Car name is\t"+car1.CarNAME);
            Console.WriteLine("Car colour is\t"+car1.Colour);
            Console.WriteLine("Car maxspeed\t"+car1.Maxspeed);

            Console.WriteLine("Second car detalis");

            car car2 = new car();
            car2.carid = 124;
            car2.CarNAME = "Maruti";
            car2.Colour= "White";
            car2.Maxspeed = 84;
            Console.WriteLine("Car id\t" + car2.carid);
            Console.WriteLine("Car id\t" + car2.CarNAME);
            Console.WriteLine("Car colour is\t" + car2.Colour);
            Console.WriteLine("Car maxspeed\t"+car2.Maxspeed);
            car2.type();
            car2.warning(); 

        }
    }
}
