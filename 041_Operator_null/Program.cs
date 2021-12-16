using System;

namespace _041_Operator_null
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            int b = 10;
            int? c = null;
            int d = 100;
            int result;

            result = a ?? b; //10
            Console.WriteLine("result: " + result);

            result = a ?? c ?? d; //100
            Console.WriteLine("result: " + result);

            c = 10000;
            result = a ?? c ?? d; //100000
            Console.WriteLine("result: " + result);
        }
    }
}
