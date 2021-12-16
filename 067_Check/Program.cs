using System;

// 함수 정리 문제 조금 이해 덜됨
namespace _067_Check
{
    class Program
    {
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("국어 성적 입력(정수)?");
            kor = int.Parse(Console.ReadLine());

            Console.Write("수학 성적 입력(정수)?");
            mat = int.Parse(Console.ReadLine());

            Console.Write("영어 성적 입력(정수)?");
            eng = int.Parse(Console.ReadLine());

            Console.WriteLine("kor: {0}, mat: {1}, eng: {2}", kor, mat, eng);
        }

        static int TotalSum(int kor, int mat, int eng)
        {
            int total = kor + mat + eng;
            return total;
        }

        static void Average(int total, out float average)
        {
            average = total / 3.0f;
        }

        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng); // ref 썼으니까 값도 변화?
            total = TotalSum(kor, mat, eng);
            Average(total, out average); // out을 써서 초기화도 없이 값도 변화?

            Console.WriteLine("Total: {0}  Average: {1}", total, average);

        }
    }
}
