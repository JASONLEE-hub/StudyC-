using System;

namespace _062_FuncSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = -100;

            ValueSwap(num1, num2);
            Console.WriteLine("num1: {0}   num2: {0}", num1, num2);

            RefSwap(ref num1, ref num2);
            Console.WriteLine("num1: {0}   num2: {0}", num1, num2);

        }

        static public void ValueSwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("ValueSwap");
            Console.WriteLine("a: {0}    b: {1}", a, b);
        }

        static public void RefSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("RefSwap");
            Console.WriteLine("a: {0}    b: {1}", a, b);
        }
    }
}
