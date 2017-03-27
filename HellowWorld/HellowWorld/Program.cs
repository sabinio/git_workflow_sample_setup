using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("{0} : commit 1 master", HelloWorld.SayHello());
            Console.WriteLine("{0} : commit 3 master", SayHello());
        }

        private static string SayHello()
        {
            return "Hello World";
        }
    }
}