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
        //function over loading 
       //  name managling 
       //메소드 
        static void Add1<T>(T x, T y)
        {
           
            //return (T)(x) + (T)(y);

        }
        static string Add3(string x, string y)
        { return x + y; }

        //반환값을 다르게 쓰는 것 
        static float Add2(float x, float y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Add1(1, 2);
            Add2(1.1f, 2.1f);
            Add3("Hello", "World");
        }
    }
}