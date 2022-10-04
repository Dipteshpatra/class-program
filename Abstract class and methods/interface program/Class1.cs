using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace interface_program
{
    interface Icalculater
    {
        void Add(int x,int y);
        void sub(int x, int y);
        void multi(int x, int y);
        void divison(int x, int y);
    }
    public class Operation : Icalculater
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("Addition:"+(x+y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub of two number:" +(x-y));
        }
        public void multi(int x, int y)
        {
            Console.WriteLine("multiplication of two number:" + x * y);
        }
        public void divison(int x, int y)
        {
            Console.WriteLine("Divison of two number:" + (x/y));
        }
    }
}
    
