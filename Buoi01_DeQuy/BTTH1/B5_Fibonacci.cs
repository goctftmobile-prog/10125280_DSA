using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BTTH1
{
    static class B5_Fibonacci
    {
        static long DeQuy(int n)
        {
            if (n < 2) return n;
            return DeQuy(n - 1) + DeQuy(n - 2);
        }

        static long VongLap(int n)
        {
            if (n < 2) return n;
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        static Dictionary<int, long> memo = new Dictionary<int, long>();
        static long DeQuyCoNho(int n)
        {
            if (n < 2) return n;
            if (memo.ContainsKey(n)) return memo[n];
            long r = DeQuyCoNho(n - 1) + DeQuyCoNho(n - 2);
            memo[n] = r;
            return r;
        }

        static long[,] Nhan(long[,] x, long[,] y)
        {
            return new long[,]
            {
                { x[0,0]*y[0,0] + x[0,1]*y[1,0], x[0,0]*y[0,1] + x[0,1]*y[1,1] },
                { x[1,0]*y[0,0] + x[1,1]*y[1,0], x[1,0]*y[0,1] + x[1,1]*y[1,1] }
            };
        }

        static long MaTran(int n)
        {
            if (n == 0) return 0;
            long[,] kq = { { 1, 0 }, { 0, 1 } };
            long[,] cs = { { 1, 1 }, { 1, 0 } };
            int p = n - 1;
            while (p > 0)
            {
                if ((p & 1) == 1) kq = Nhan(kq, cs);
                cs = Nhan(cs, cs);
                p >>= 1;
            }
            return kq[0, 0];
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n (0..90)", 30);
            if (n < 0 || n > 90) { Console.WriteLine("n phai nam trong khoang 0..90."); return; }

            Stopwatch sw = new Stopwatch();

            sw.Restart(); long r1 = DeQuy(n); sw.Stop();
            Console.WriteLine($"De quy truc tiep: {r1}  ({sw.Elapsed.TotalMilliseconds:F3} ms)");

            sw.Restart(); long r2 = VongLap(n); sw.Stop();
            Console.WriteLine($"Vong lap: {r2}  ({sw.Elapsed.TotalMilliseconds:F3} ms)");

            memo.Clear();
            sw.Restart(); long r3 = DeQuyCoNho(n); sw.Stop();
            Console.WriteLine($"De quy co nho: {r3}  ({sw.Elapsed.TotalMilliseconds:F3} ms)");

            sw.Restart(); long r4 = MaTran(n); sw.Stop();
            Console.WriteLine($"Luy thua ma tran: {r4}  ({sw.Elapsed.TotalMilliseconds:F3} ms)");
        }
    }
}
