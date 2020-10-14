using System;
using System.Globalization;
using static Input.Program;

namespace For
{
    public class Program
    {
        static void Main(string[] args)
        {
            For13(IntInput());
        }


        static void For1()
        {
            int k = IntInput();
            int n = IntInput();
            for (int i = 0; i < n; i++) 
                Console.WriteLine(k);
        }
        static void For5()
        {
            double cost = DoubleInput();
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(cost * i*0.1);
        }
        static void For9()
        {
            int a = IntInput(), b = IntInput();
            int sum = 0;
            for (int i = a; a <= b; i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
        public static double For13(int n)
        {
            int sign = 1;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (1 + i / 10.0) * sign;
                sign *= -1;
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void For17()
        {
            int n = IntInput();
            double a = DoubleInput();
            double sum = 1;
            for (int i = 0; i < n-1; i++) 
            {
                sum += a;
                a*= a;
            }
            Console.WriteLine(sum);
        }
        static void For21()
        {
            int n = IntInput();
            int factorial = 1;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += 1.0 / factorial;
            }
            Console.WriteLine(sum);
        }
        static void For25()
        {
            int sign = 1;
            double x = DoubleInput();
            double x2 = x;
            int n = IntInput();
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += x2 / i * sign;
                sign *= -1;
                x2 *= x;
            }
            Console.WriteLine(sum);
        }
        static void For29()
        {
            int n = IntInput();
            double a = DoubleInput();
            double b = DoubleInput();
            double h = (b - a) / n;
            for (int i = 0;a+i*h<=b;i++)
            {
                Console.WriteLine(a+i*h);
            }
        }
        static void For33()
        {
            int n = IntInput();
            int f1=0, f2=1, f3=1;
            for (int i = 0; i < n; i++)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            Console.WriteLine(f1);
        }
        static void For37()
        {
            int n = IntInput();
            double b=1;
            double sum=0;
            for (int i = 1; i <= n; i++) 
            {
                b = i;
                for (int j = 1; j < i; j++)
                {
                    b *= i;
                }
                sum += b;
            }
            Console.WriteLine(sum);
        }
    }
}
