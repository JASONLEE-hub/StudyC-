using System;

/// <summary>
/// DESC: 클래스 생성자, 소멸자 
/// </summary>

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}",a);
            Console.WriteLine(" f: {0}",f);
        }

        public AA(int _a)
        {
            a = _a;

            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }

        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;
            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }

        ~AA()
        {
            Console.WriteLine(" Call Destructor ");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100,50);
        }
    }
}
