using System;

namespace FunWithTypes
{
    class Program
    {
        static void Main()
        {
            double pi = Math.PI;
            int oneThousand = (int)1000L;
            float piF = (float)pi;
            float oneThousandPi = (float)(piF * oneThousand);
            int rounded1000Pi = (int)Math.Round(oneThousandPi);
            int integerPart = (int)oneThousandPi;
            Console.WriteLine(rounded1000Pi);
            Console.WriteLine(integerPart);

            double a = 10;
            a = a + 0.5;
            Console.WriteLine(a);

            var b = 15;
            var c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
