using System;

namespace _076_Check
{
    class Program
    {
        static int[] a = new int[10];
        static int[] b = new int[10];
        static int[] result = new int[10];
        static int count = 1;

        static void InputNumber(int count)
        {

            for (int i = 0; i < 10; i++)
            {
                    Console.Write("첫번째 수를 입력하세요.");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("두번째 수를 입력하세요.");
                    b[i] = Convert.ToInt32(Console.ReadLine());
                    result[i] = a[i] + b[i];
                    Console.WriteLine("{0} + {1} = {2}", a[i], b[i], result[i]);
                    Console.Write("추가로 계산할까요(1:OK,0:NO,단 총 10번까지만 가능");
                    count = Convert.ToInt32(Console.ReadLine());
                    if (!CheckEnd(count))
                    {
                        break;
                    }
            }
        }

        static void printResult()
        {
            foreach (int data in a)
            {
                Console.WriteLine("첫번째 수 : {0}", data);
            }
            foreach (int data in b)
            {
                Console.WriteLine("두번째 수 : {0}", data);
            }
            foreach (int data in result)
            {
                Console.WriteLine("합친수 : {0}", data);
            }

        }

        static bool CheckEnd(int count)
        {
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        static void Main(string[] args)
        {
            InputNumber(count);
            printResult();
        }
    }
}
