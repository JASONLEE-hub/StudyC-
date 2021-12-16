using System;

namespace _20_Data_enum2
{
    class Program
    {
        enum CHAR_STATE
        {
            IDLE,
            WALK,
            RUN,
            DIE,
        }

        enum CLICK_STATE
        {
            NONE,
            CLICK = 100, //100th
            DOUBLE_CLICK = 200, //200th
            UP, //201th
        }

        static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태: {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.RUN;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);

            charState = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);

            Console.WriteLine("CLICK_STATE: {0} {1}", CLICK_STATE.NONE, (int)CLICK_STATE.NONE);
            Console.WriteLine("CLICK_STATE: {0} {1}", CLICK_STATE.CLICK, (int)CLICK_STATE.CLICK);
            Console.WriteLine("CLICK_STATE: {0} {1}", CLICK_STATE.DOUBLE_CLICK, (int)CLICK_STATE.DOUBLE_CLICK);
            Console.WriteLine("CLICK_STATE: {0} {1}", CLICK_STATE.UP, (int)CLICK_STATE.UP);
        }
    } 
}
