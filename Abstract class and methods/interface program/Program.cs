using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation o = new Operation();
            o.Add(5,6);
            o.sub(12,6);
            o.multi(6,7);   
            o.divison(10,2);
        }
    }
}
