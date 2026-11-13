using System;

namespace BTTH1
{
    static class B2C3
    {
        static long S(int n)
        {
            if (n == 1) return 1;
            return S(n - 1) + (long)n * n;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (n > 0)", 10);
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"S({n}) = 1 + 2^2 + ... + {n}^2 = {S(n)}");
        }
    }
}
