using System;

/// <summary>
/// DESC: 클래스 객체의 복사를 통한 레퍼런스 처리 및 객체 생성 후 리턴되는 값 확인 
/// </summary>

namespace _081_class_parameter
{
    class AA
    {
        public int a;
        public int b;

        public AA()
        {
            a = 0;
            b = 0;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.Print();

            CopyRefClass(aa);
            aa.Print();

            AA aaa = CopyDeepClass(aa);
            aaa.Print();

            aa.Print();


        }

        static void CopyRefClass(AA aa)
        {
            AA refAA = aa; // 레퍼런스 ,, 값이 변경됨..
            refAA.a = 100;
            refAA.b = 10000;
        }

        static AA CopyDeepClass(AA aa)
        {
            AA tempAA = new AA(); // 새 객체 생성

            tempAA.a = aa.a;  // 새 객체에 기존 레퍼런스를 넣.. 
            tempAA.b = aa.b;
            tempAA.a = 0;

            return tempAA;  // 그걸 돌려보냄 어케 될까??

        }
    }

}
