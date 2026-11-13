using System;

namespace BTTH1
{
    static class B7C3
    {
        static int SoChuSo(long n)
        {
            if (n == 0) return 0;
            return SoChuSo(n / 10) + 1;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (n > 0)", 12345);
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"So chu so cua {n} la {SoChuSo(n)}");
        }
    }
}
