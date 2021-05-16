using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace lib4_2
{
    class Program
    {
        [DllImport("Mathematics.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Sum (int a, int b);
        [DllImport("Mathematics.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Pow(int a, int b);
        [DllImport("Mathematics.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Multiply(int a, int b);
        [DllImport("Mathematics.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Divide(int a, int b);
        [DllImport("Mathematics.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Mod(int a, int b);
        static void Main()
        {
                Console.WriteLine("Введите две переменные");
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(3000);
                Console.Clear();
            Console.WriteLine($"{a} + {b} = " + Sum(a, b));
            Console.WriteLine($"{a} ^ {b} = " + Pow(a, b));
            Console.WriteLine($"{a} * {b} = " + Multiply(a, b));
            Console.WriteLine($"{a} / {b} = " + Divide(a, b));
            Console.WriteLine($"{a} % {b} = " + Mod(a, b));
        }
    }
}
