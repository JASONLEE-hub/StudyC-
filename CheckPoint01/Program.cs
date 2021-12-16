using System;
using System.Threading;

namespace CheckPoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const string LINE = "--------------------------------";
            const int END_LINE = 32;
            const int DELAY_TIME = 100;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;

            while (true)
            {
                Thread.Sleep(DELAY_TIME); //딜레이
                Console.Clear(); //화면 지우기

                int rndNum = rnd.Next(0, 4); // 0~3
                int runRndNum = rnd.Next(0, 2); 

                switch (rndNum)
                {
                    case 0:
                        runA += runRndNum;
                        break;
                    case 1:
                        runB += runRndNum;
                        break;
                    case 2:
                        runC += runRndNum;
                        break;
                    case 3:
                        runD += runRndNum;
                        break;
                }


                Console.WriteLine(LINE);

                //1번 주자 
                Console.Write("|출|");
                for (int i = 0; i < runA; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("1♞");
                for (int i = END_LINE - (runA+4); i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|도|");

                //2번 주자  
                Console.Write("|ㅁ|");
                for (int i = 0; i < runB; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("2♞");
                for (int i = END_LINE - (runB+4); i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|ㅁ|");

                //3번 주자
                Console.Write("|ㅁ|");
                for (int i = 0; i < runC; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("3♞");
                for (int i = END_LINE - (runC+4); i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|ㅁ|");

                //4번 주♞
                Console.Write("|발|");
                for (int i = 0; i < runD; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("4♞");
                for (int i = END_LINE - (runD+4); i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|착|");

                Console.WriteLine(LINE);

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int runNum = 0;
                    string strResult = "결과: !!{0} 선수 우승!!";

                    if (runA >= END_LINE)
                        runNum = 1;
                    else if (runB >= END_LINE)
                        runNum = 2;
                    else if (runC >= END_LINE)
                        runNum = 3;
                    else
                        runNum = 4;

                    Console.WriteLine(strResult, runNum);

                    Console.Write("다시하시려면 0번을 입력:");
                    if("0" == Console.ReadLine())
                    {
                        runA = 0;
                        runB = 0;
                        runC = 0;
                        runD = 0;
                    }
                    else
                    {
                        break;
                    }

                }


            }
        }
    }
}
