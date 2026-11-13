using System;

namespace BTTH1
{
    static class B3C3
    {
        static double S(int n)
        {
            if (n == 1) return 1;
            return S(n - 1) + 1.0 / n;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (n > 0)", 10);
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"S({n}) = 1 + 1/2 + ... + 1/{n} = {S(n):F6}");
        }
    }
}
