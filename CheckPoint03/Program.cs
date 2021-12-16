using System;
using System.Threading;

/// <summary>
/// CheckPoing03 - 배열을 활용하여 2D 구조  
/// </summary>

namespace CheckPoint03
{

    class Program
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateGo(int[] arrIndexX, int[,] map)
        {
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = arrIndexX[i];

                int temp = map[indexMaxX, indexY]; //temp = 3; swap!!
                map[indexMaxX, indexY + 1] = temp;
                map[indexMaxX, indexY] = 0;

                if (arrIndexX[i] < 19)
                    arrIndexX[i]++;
            }

        }

        static bool UpdateRndGo(int[]arrIndexX, int[,]map, Random rnd)
        {
            bool isFinish = false;

            for (int i = 0; i < arrIndexX.Length; i++)
            {
                if(arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }

            int rndIndex = rnd.Next(0, 5);

            int indexY = arrIndexX[rndIndex];

            int temp = map[rndIndex + 1, indexY]; //rndIndex
            map[rndIndex + 1, indexY + 1] = temp;
            map[rndIndex + 1, indexY] = 0;

            arrIndexX[rndIndex]++;

            return isFinish;
        }

        static void UpdateView(char[] tile, int[,] map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = map[i, j]; // 타일의 인덱스 저장 0,0 0,1 
                    Console.Write(tile[tileIndex]); // 그걸을 타일에서 가져와 그림

                    if (j == MAP_Y - 1)
                        Console.WriteLine(); // 배열의 특성상 한번 다찍고 라인 바꾸려고

                }
            }
        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            //               0    1    2    3    4    5    6    7 
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, //-
                {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0}, //1
                {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0}, //2
                {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0}, //3
                {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0}, //4
                {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0}, //5
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}  //-
             };

            int[] arrIndexX = { 0, 0, 0, 0, 0 }; //변한다
            bool isFinish = false;

            while (true)
            {


                if (isFinish)
                {
                    Console.WriteLine();

                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("달리기 결과는 1등:{0}번", i+1);
                            break;
                        }
                    }

                    Console.WriteLine();
                    Console.Write("다시 시작하려면 0을 입력하세요.");
                    string inputStr = Console.ReadLine(); // 기다리기

                    if(inputStr == "0")
                    {
                        map[1, arrIndexX[0]] = 0;
                        map[2, arrIndexX[1]] = 0;
                        map[3, arrIndexX[2]] = 0;
                        map[4, arrIndexX[3]] = 0;
                        map[5, arrIndexX[4]] = 0;

                        arrIndexX[0] = 0;
                        arrIndexX[1] = 0;
                        arrIndexX[2] = 0;
                        arrIndexX[3] = 0;
                        arrIndexX[4] = 0;

                        map[1, 20] = 2;
                        map[2, 20] = 2;
                        map[3, 20] = 2;
                        map[4, 20] = 2;
                        map[5, 20] = 2;

                        map[1, 0] = 3;
                        map[2, 0] = 4;
                        map[3, 0] = 5;
                        map[4, 0] = 6;
                        map[5, 0] = 7;


                    }
                    else
                    {
                        break;
                    }
                }

                ClearView();
                UpdateGo(arrIndexX, map);
                isFinish = UpdateRndGo(arrIndexX, map, rnd);
                UpdateView(tile, map);

            }   
        }
    }
}


