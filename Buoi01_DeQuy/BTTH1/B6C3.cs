using System;

namespace BTTH1
{
    static class B6C3
    {
        static int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        public static void Run()
        {
            int a = hamhotro.DocSo("Nhap a (a > 0)", 48);
            int b = hamhotro.DocSo("Nhap b (b > 0)", 18);
            if (a <= 0 || b <= 0) { Console.WriteLine("a, b phai la so nguyen duong."); return; }
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
        }
    }
}
