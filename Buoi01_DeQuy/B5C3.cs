using System;

namespace BTTH1
{
    static class B5C3
    {
        static long UocLeMax(long n)
        {
            if (n % 2 == 1) return n;
            return UocLeMax(n / 2);
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (n > 0)", 100);
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"Uoc le lon nhat cua {n} la {UocLeMax(n)}");
        }
    }
}
