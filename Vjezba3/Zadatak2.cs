using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba3
{
    class Zadatak2
    {
        
        public static int Fibonnaci(int broj)
        {
            int fibonaciBroj;
            if (broj <= 1)
            {
                return broj;
            }
            else
            {
                fibonaciBroj = Fibonnaci(broj - 1) + Fibonnaci(broj - 2);
                return fibonaciBroj;
            }
        }
        public static int FibonnaciEvenSum(int broj)
        {
            if (broj < 2)
                return 0;

            int a = 0, b = 2;
            int sum = a + b;

            while (b <= broj)
            {

                int c = 4 * b + a;

                if (c > broj)
                    break;

                a = b;
                b = c;
                sum += b;
            }

            return sum;
        
        }

        public static int FibonnaciOddSum(int broj)
        {
            int sum = 0;
            int a = 1;
            int b = 1;
            int temp;
            while (a <= broj)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                }
                temp = a;
                a += b;
                b = temp;
            }

            return sum;
        }
    }
}

