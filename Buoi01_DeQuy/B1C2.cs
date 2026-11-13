using System;

namespace BTTH1
{
    static class B1C2
    {
        static long demBuoc;

        static void Hanoi(int n, char tu, char den, char trungGian, bool in_)
        {
            if (n == 0) return;
            Hanoi(n - 1, tu, trungGian, den, in_);
            demBuoc++;
            if (in_) Console.WriteLine($"Chuyen dia {n}: {tu} -> {den}");
            Hanoi(n - 1, trungGian, den, tu, in_);
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap so dia n", 3);
            if (n < 0 || n > 30) { Console.WriteLine("n phai nam trong khoang 0..30."); return; }
            demBuoc = 0;
            Hanoi(n, 'A', 'C', 'B', n <= 5);   // chi in chi tiet khi n nho
            Console.WriteLine($"Tong so buoc: {demBuoc}(ly thuyet 2^n - 1 = {(1L << n) - 1})");
        }
    }
}
