using System;

namespace Input
{
    public static class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int IntInput()
        {
            if (int.TryParse(Console.ReadLine(), out int a))
            {
                return a;
            }
            return 0;
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
            bool b = true;
            for (i = 0; i < a.Length & b; i++) 
            {
                a[i] = rnd.Next(21);
                if (a[i] == 0) b = false;
            }
            a[a.Length - 1] = 0;
            return a;
        }
    }
}
