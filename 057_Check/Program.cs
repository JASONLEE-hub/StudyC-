using System;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 0;
            for (int i=0; i<5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                string str = Console.ReadLine();
                int inputNum = int.Parse(str);
                if(i == 0)
                {
                    min = inputNum;
                    max = inputNum;
                }
                else
                {
                    if(inputNum < min)
                    {
                        min = inputNum;
                    }
                    else if(inputNum > max)
                    {
                        max = inputNum;
                    }
                }
            }
            Console.WriteLine("최대값: {0}  최소값: {1}", max, min);
        }
    }
}
