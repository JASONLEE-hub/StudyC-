using System;

namespace _075_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id = new int[3];
            int[] kor = new int[100];
            int[] math = new int[100];
            int[] eng = new int[100];
            int input = 1;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("학생 ID를 입력하세요?");
                string str = Console.ReadLine();
                id[i] = Convert.ToInt32((str));

                Console.WriteLine("국어 점수를 입력하세요?");
                kor[id[i]] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("수학 점수를 입력하세요?");
                math[id[i]] = Convert.ToInt32((Console.ReadLine()));

                Console.WriteLine("영어 점수를 입력하세요?");
                eng[id[i]] = Convert.ToInt32((Console.ReadLine()));

            }

            

            while(input != 0)
            {
                Console.WriteLine("학생 ID를 입력하세요? (0)나가기");
                input = Convert.ToInt32(Console.Read());

                for (int i = 0; i < 3; i++)
                {
                    if (input == id[i])
                    {
                        Console.WriteLine("학생 ID: ");

                    }
                    else
                    {
                        Console.WriteLine("학생 아이디가 없어. 다시 입력하세요");
                    }

                }
            }


        }
    }
}
