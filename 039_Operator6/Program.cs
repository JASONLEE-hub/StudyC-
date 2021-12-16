using System;

namespace _039_Operator6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool result;

            result = (num == 0) ? true : false;
            Console.WriteLine("num: {0}", num);
            Console.WriteLine("(num == 0) ? true : false : {0}", result);

            result = (num > 10) ? true : false;
            Console.WriteLine("(num > 0) ? true : false : {0}", result);
        }
    }
}
