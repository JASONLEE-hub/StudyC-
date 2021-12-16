using System;

namespace _031_ReadLine2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 정수를 입력하세요.");
            string str1 = Console.ReadLine();
            Console.WriteLine("두번째 정수를 입력하세요.");
            string str2 = Console.ReadLine();

            int num1 = int.Parse(str1);
            int num2 = int.Parse(str2);

            int sum = num1 + num2; // "+" 두수의 합..
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
        }
    }
}
