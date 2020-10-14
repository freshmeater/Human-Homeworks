using System;
using static Input.Program;

namespace While
{
    public class Program
    {
        static void Main(string[] args)
        {
            While29();
        }
        static void While1()
        {
            int a = IntInput();
            int b = IntInput();
            while (a - b >= 0)
            {
                a -= b;
            }
            Console.WriteLine(a);
        }
        static void While5()
        {
            int n = IntInput();
            int i;
            for (i = 0; n != 1; i++) 
            {
                n /= 2;
            }
            Console.WriteLine(i);
        }
        static void While9()
        {
            int n = IntInput();
            int a = 3;
            int c = 1;
            while (a <= n)
            {
                a *= 3;
                c++;
            }
            Console.WriteLine(c);
        }
        static void While13()
        {
            int a = IntInput();
            int k;
            double sum=0;
            for (k = 0; sum <= a; k++)
            {
                sum += 1.0 / (k+1);
            }
            Console.WriteLine(sum);
            Console.WriteLine(k);
        }
        static void While17()
        {
            int a = IntInput();
            while (a>0)
            {
                Console.WriteLine(a % 10);
                a /= 10;
            }
        }
        static void While21()
        {
            int a = IntInput();
            while (a>0)
            {
                if ((a % 10) % 2 == 1)
                {
                    Console.WriteLine("True");
                    return;
                }
                a /= 10;
            }
            Console.WriteLine("False");
        }
        static void While25()
        {
            int n = IntInput();
            int f1=1, f2=1, f3=1;
            while (n>=f3)
            {
                f1 = f2;
                f2 = f3;
                f3 = f2 + f1;
            }
            Console.WriteLine(f3);
        }
        static void While29()
        {
            int n = IntInput();
            double f1 = 1, f2 = 1, f3 = 2;
            while (n <= Math.Abs(f3-f2))
            {
                f1 = f2;
                f2 = f3;
                f3 = (2*f2 + f1)/3;
            }
            Console.WriteLine(f3);
            Console.WriteLine(f2);
        }
    }
}
