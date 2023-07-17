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

        //포인터의 이해
        // 범위가 중괄호 까지
        static void swap(ref int x, ref int y)
        {
            int c = 0;
            /*  c = b;
                b = a;
                a = c;
            }*/
        }

        /*ref는 호출한 애거 쓰는 거
            out은 결과만 주는 것 
        const = 상수 */ 
        
        static void Calculate(int a, int b, out int outsum, out float outavg)
        {
outsum = a + b;
            outavg = (float)outsum / 2.0f;
        }
        //ref는 멀리  있는 값을 가져다 씀 
        //위랑 아래랑 마치 강원도 경기도 같은 느낌
            static void Main(string[] args)
        {

            int a = 1;
            int b = 2;

            swap(ref a, ref b);
           
        
            Console.WriteLine(a);
            Console.WriteLine(b);

            int sum = 0;
            float avg = 0;
            Calculate(a, b, out sum, out avg);

            //hitinfo == out 
            //out =출력= 은 값을 받아오는 것
            Console.WriteLine(sum);
            Console.WriteLine(avg);

            //using 한정해서 범위를 짓는 것 

        }
    }
}
