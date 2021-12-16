using System;

namespace _028_Data_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int refNum = num;
            refNum = 1000;

            Console.WriteLine("refStr: {0}   ReferenceEquals: {1}", num, Object.ReferenceEquals(num, refNum));

            int[] arrNum = { 100, 200 };
            int[] refArrNum = arrNum;
            refArrNum[0] = 1000;
            Console.WriteLine("refStr: {0}   ReferenceEquals: {1}", arrNum[0], Object.ReferenceEquals(refArrNum, arrNum));

        }
    }
}
