using System;

namespace BTTH1
{
    static class B4C3
    {
        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1;
            return LuyThua(x, n - 1) * x;
        }

        static double S(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n);
        }

        public static void Run()
        {
            Console.Write("Nhap x (Enter = 2): ");
            string s = Console.ReadLine();
            double x = double.TryParse(s, out double v) ? v : 2;
            int n = hamhotro.DocSo("Nhap n", 10);
            if (x == 0 && n < 0) { Console.WriteLine("Khong xac dinh (chia cho 0)."); return; }
            Console.WriteLine($"S({x}, {n}) = {x}^{n} = {S(x, n)}");
        }
    }
}
