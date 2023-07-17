using System;
using System.Collections.Generic;
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
            int[,] map = {
                {1,1,1,1,1,1,1,1,1,1 },
                {1,0,0,0,0,0,0,0,0,1},
            { 1,0,0,0,0,0,0,0,0,1}
        };

            int PlayerY = 5;
            int PlayerX = 3;


            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    {
                        if (PlayerX == x && PlayerY == y) ;

                        else if (map[y, x] == 1)
                        {
                            Console.WriteLine("*");
                        }



                    }
                }
            }
        }
    }
}
    
c