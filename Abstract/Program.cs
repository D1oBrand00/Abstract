using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<DerivedClass> der = new List<DerivedClass>();
            DerivedClass der = new DerivedClass();
            der.Method();
            der.Sum(1,5);
            der.SayHello("Hi");
            der.SayHello1("Bye");
            Console.ReadKey();
            

        }
    }
}
