using System;

namespace Input
{
    public static class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int IntInput(int type = 0)
        {
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                throw new Exception("You`re trying to input wrong digit");
            }
            return type switch
            {
                1 => a > 0 ? a : 1,
                _ => a,
            };
        }
        public static double DoubleInput()
        {
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                return a;
            }
            return 0;
        }
        public static int[] IntInit(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = IntInput();
            }
            return a;
        }
        public static double[] DoubleInit(int n)
        {
            double[] a = new double[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = DoubleInput();
            }
            return a;
        }
        public static int[] SetOfNumbers()
        {
            Random rnd = new Random();
            int[] a = new int[rnd.Next(20)+1];
            int i = 0;
            for (i = 0; i < a.Length; i++) 
            {
                a[i] = rnd.Next(20)+1;
            }
            a[a.Length - 1] = 0;
            return a;
        }
    }
}
