using System;
namespace gameProject
{
    internal class Program
    {
        static void showData()
        {
            Console.WriteLine("외부데이터 없이 자체 동작");
        }
        static int divide(int x, int y)
        {
            if (y != 0)
            {
                int retval;
                retval = x / y;
                Console.WriteLine("{0} {1}을 나눈 값: {2}", x, y, retval);
                return retval;
            }
            else
            {
                Console.WriteLine("0으로 나눌 수 없음.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            showData();
            divide(7, 3);
            divide(0, 3);
            divide(7, 0);

        }
    }
}