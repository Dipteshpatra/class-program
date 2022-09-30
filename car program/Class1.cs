using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_program
{
    class car
    {
        private int id;
        private string carname;
        private string colour;
        private int maxspeed;
        public int carid
        {
            get { return id; }
            set { id = value; } 
        }

        public string CarNAME
        {
            get { return carname; }
            set { carname = value; }    
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; } 
        }
        public int Maxspeed
        {
            get { return maxspeed; }
            set { maxspeed = value; }
        }
        public void type()
        {
            if (id < 200)
                Console.WriteLine("type of the car is Manual and petrol");
            else
                Console.WriteLine("type of the car is automatic and disel");
            
        }
        public void warning()
        {
            if (maxspeed > 100)
                Console.WriteLine("Please think about your family");
            else
             Console.WriteLine("you are in right track sir");
        }

    }
}
