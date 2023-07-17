using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L20230712
{
    internal class Program
    {

        static void A()
        {
            Console.WriteLine("A");

        }

        static int Add(int x, int y)
        {
            A();
            return x + y;

        }
        static float Add(float x, float y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(1.1f, 2.1f);
        }
    }
}