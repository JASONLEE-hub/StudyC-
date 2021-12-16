using System;

/// <summary>
/// 083 override
/// 오버라이딩(다형성)
/// 같은 기능을 하는 함수를 오버라이딩해서 다른 기능을 추가적으로 할 수 있도록...
/// </summary>

namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Super
    {
        public int a;

        public override void Print()
        {
            base.Print(); // 없어도 상관없음 ..

            Console.WriteLine("AA a: {0}", a);
        }
    }

    class BB : Super
    {
        public int b;

        public override void Print()
        {
            base.Print();

            Console.WriteLine("BB b: {0}", b);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super.Print();

            Super aa = new AA();
            aa.Print();

            Super bb = new BB();
            bb.Print();
        }
    }
}
