using System;

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int anwser = 0;
            while( i != 5){
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", i);
                Random rnd = new Random();
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);
                Console.WriteLine("{0} + {1} = ??", a, b);
                int sum = a + b;
                string inputStr = Console.ReadLine();
                int inputInt = int.Parse(inputStr);
                if (inputInt == sum)
                {
                    Console.WriteLine("== 정답 ==");
                    anwser++;
                }
                else
                {
                    Console.WriteLine("오답(정답은:{0})", sum);
                }
                i++;
            }
            Console.WriteLine("총 {0}문제 맞춤", anwser);
        }
    }
}
