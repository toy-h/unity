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
        static void Main(string[] args)
        {
            int num =  1;
            Console.Write(num + "는 " );

            if (0 <= num && num <= 9)

                Console.WriteLine("1자리의 수입니다");

            else if (10 <= num && num <= 99)
                Console.WriteLine("2자리의 수입니다.");
            else if (100 <= num && num <= 999)
                Console.WriteLine("3자리의 수입니다.");
            else Console.WriteLine("4자리 이상의 수입니다.");
            }
        }
    }
