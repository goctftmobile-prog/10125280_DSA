using System;

namespace BTTH1
{
    static class B8C3
    {
        static double Can(int i, int n)
        {
            if (i == n) return Math.Sqrt(n);
            return Math.Sqrt(i + Can(i + 1, n));
        }

        static double S(int n)
        {
            return Can(1, n);
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (n > 0)", 10);
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"S({n}) = {S(n):F6}");
        }
    }
}
