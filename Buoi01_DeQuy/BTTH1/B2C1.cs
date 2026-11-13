using System;

namespace BTTH1
{
    static class B2C1
    {
        const int SoCot = 5;
        const int SoHang = 20;

        static string KetQua(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";
            return i.ToString();
        }

        public static void Run()
        {
            Console.WriteLine();

            for (int r = 0; r < SoHang; r++)
            {
                Console.Write("  ");
                for (int c = 0; c < SoCot; c++)
                {
                    int i = c * SoHang + r + 1;
                    Console.Write(KetQua(i).PadRight(12));
                }
                Console.WriteLine();
            }
        }
    }
}