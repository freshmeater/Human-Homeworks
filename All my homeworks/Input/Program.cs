using System;

namespace Input
{
    public static class Program
    {
        static void Main(string[] args)
        {

        }

        public static int ModifyIntByRule(this int a, Func<int, int> modifyRule)
            => modifyRule(a);

        public static double ModifyDoubleByRule(this double a, Func<double, double> modifyRule)
    => modifyRule(a);

        public static int GetIntInput(Func<int, int> modifyRule) =>
            IntInput().ModifyIntByRule(modifyRule);

        public static double GetDoubleInput(Func<int, int> modifyRule) =>
            IntInput().ModifyIntByRule(modifyRule);

        public static int GetPositiveInt()
            => GetIntInput(a => a > 0 ? a : 1);
        public static double GetPositiveDouble()
     => GetDoubleInput(a => a > 0 ? a : 1);

        public static int IntInput() => 
            int.TryParse(Console.ReadLine(), out int a) ? a : throw new Exception("You`re trying to input wrong digit");

        public static double DoubleInput() =>
            double.TryParse(Console.ReadLine(), out double a) ? a : throw new Exception("You`re trying to input wrong digit");

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
