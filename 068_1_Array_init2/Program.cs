using System;

namespace _068_1_Array_init2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNum = new int[3];
            int[] arrNum2 = new int[] { 0, 1, 2 };
            int[] arrNum3 = new int[3] { 0, 1, 2 };
            int[] arrNum4 = { 0, 1, 2 };

            //arrWeek[7]{ "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            string[] arrWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            for(int i = 0; i < arrNum.Length; i++)
            {
                arrNum[i] = i;
            }

            for(int i = 0; i < arrNum.Length; i++)
            {
                Console.Write(" {0} ", arrNum[i]);
            }

            Console.WriteLine("`n-------------------------------");

            Console.WriteLine("arrNum3: ");
            foreach(int temp in arrNum3)
            {
                //temp = 1000; //오류:foreach는 읽기 전용
                Console.Write(" {0}", temp);
            }

        }
    }
}
