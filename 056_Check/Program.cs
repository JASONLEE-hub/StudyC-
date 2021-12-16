using System;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 100);
            int num = 1;
            int check = 0;
            while(num != 0)
            {
                Console.Write("1~99사이에 어떤 숫자일까요(단, 0은 나가기)");
                string input;
                input = Console.ReadLine();
                num = int.Parse(input);
                if(random > num)
                {
                    Console.WriteLine("입력한 수는 커요");
                    check++;
                }
                else if(random < num)
                {
                    Console.WriteLine("입력한 수는 작아요");
                    check++;
                }
                else if(random == num)
                {
                    Console.WriteLine("=== 정답입니다. ==");
                    check++;
                    Console.WriteLine("총 {0}번 시도", check);
                    break;
                }
            }
        }
    }
}
