using System;

namespace _032_033_DataCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';

            Console.WriteLine("a : {0}, a.GetType(): {1}", a, a.GetType());
            Console.WriteLine("b : {0}, b.GetType(): {1}", b, b.GetType());
            Console.WriteLine("c : {0}, c.GetType(): {1}", c, c.GetType());
            Console.WriteLine("d : {0}, d.GetType(): {1}", d, d.GetType());

            Console.Write("국어 점수 입력하세요?");
            string inputNum1 = Console.ReadLine();
            int kukA = int.Parse(inputNum1);

            Console.Write("영어 점수 입력하세요?");
            string inputNum2 = Console.ReadLine();
            int english = Convert.ToInt32(inputNum2);

            Console.Write("수학 점수 입력하세요?");
            string inputNum3 = Console.ReadLine();
            int math = int.Parse(inputNum3);

            Console.Write("과학 점수 입력하세요?");
            int science = int.Parse(Console.ReadLine());

            Console.WriteLine("국어: {0}  영어: {1}  수학: {2}  과학: {3}", kukA,english,math,science);
            Console.WriteLine("총점: {0}  평균: {1}",kukA+english+math+science, (kukA+english+math+science)/4f);
        }
    }
}
