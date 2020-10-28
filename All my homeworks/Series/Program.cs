using System;
using static Input.Program;

namespace Series
{
    public class Program
    {
        static void Main(string[] args)
        {
            Series28();
        }
        static void Series8()
        {
            int n = GetPositiveInt();
            int k = 0;
            int[] a = IntInit(n);
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                    k++;
                }
            }
            Console.WriteLine(k);
        }
        public static bool Series10(int n, int[] a)
        {
            if (a == null | n == 0) return false;
            bool b = false;
            foreach (int x in a)
            {
                if (x > 0) b = true;
            }
            return b;
        }
        static int  Series12()
        {
            int k = 0;
            int[] a = SetOfNumbers();
            for (int i = 0; a[i] !=0; i++)
            {
                k++;
            }
            return k;
        }
        static int Series14()
        {
            int k = IntInput();
            int s = 0;
            int[] a = SetOfNumbers();
            for (int i = 0; a[i] != 0; i++)
            {
                if (a[i] < k) s++;
            }
            return s;
        }
        static int Series16()
        {
            int[] a = SetOfNumbers();
            int ls = 0, k = IntInput();
            for(int i = 0; a[i] != 0; i++)
            {
                if (a[i] > k) ls = i;
            }
            return ls;
        }
        static void Series18()
        {
            int n = GetPositiveInt();
            int[] a = IntInit(n);
            Console.WriteLine(a[0]);
            for (int i = 1; i < n; i++)
            {
                if (a[i] != a[i - 1]) Console.WriteLine(a[i]);
            }
        }
        static void Series20()
        {
            int n = GetPositiveInt();
            int[] a = IntInit(n);
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i + 1]) Console.WriteLine(a[i]);
            }
        }
        static double Series22()
        {
            int n = GetPositiveInt();
            double[] a = DoubleInit(n);
            int ld = 0;
            int i;
            for (i = 1; i < n; i++)
            {
                if (a[i] > a[i - 1])
                {
                    ld = i;
                    break;
                }
            }
            if (ld + 1 == i - 1)
                return 0;
            else return a[ld];
        }
        static int Series23()
        {
            int n = GetPositiveInt();
            int[] a = IntInit(n);
            int ld = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((a[i - 1] > a[i] & a[i] > a[i + 1]) | (a[i - 1] < a[i] & a[i] < a[i + 1]))
                {
                    continue;
                }
                else
                {
                    ld = i;
                    break;
                }
            }
            return ld;
        }
        static void Series26()
        {
            int n = GetPositiveInt(), k = IntInput();
            double[] a = DoubleInit(n);
            double st;
            foreach(double x in a)
            {
                st = 1;
                for(int i = 0; i < k; i++)
                {
                    st *= x;
                }
                Console.WriteLine(st);
            }
        }
        static void Series28()
        {
            int n = GetPositiveInt();
            double[] a = DoubleInit(n);
            double st = 1;
            for(int i = 0; i < n; i++)
            {
                st = 1;
                for(int j = i; j < n; j++)
                {
                    st *= a[i];
                }
                Console.WriteLine(st);
            }
        }
    }
}
