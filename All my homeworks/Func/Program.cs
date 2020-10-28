using System;
using static Input.Program;

namespace Func
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void DigitCountSum(int k, out int c, out int s)
        {
            c = DigitsOperation(k,a => 1);
            s = DigitsOperation(k,a => a % 10);
        }
        static int DigitsOperation(int k, Func<int,int> op)
        {
            int c = 0;
            while (k != 0)
            {
                c+=op(k);
                k /= 10;
            }
            return c;
        }
        public static void AddRightDigit(int d, ref int k)
        {
            k *= 10;
            k += d;
        }
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        public static int Sign(int a) => 
            a == 0 ? 0 : a > 0 ? 1 : -1;

        static double CircleS(double r) => 
            r * Math.PI * Math.PI;

        static double TriangleP(double a, double h) => 
            a + 2 * Math.Sqrt(a * a / 4 + h * h);

        static double Calc(double a, double b, int op) =>
            op switch
            {
                1 => a - b,
                2 => a * b,
                3 => a / b,
                _ => a + b
            };
    }
}
