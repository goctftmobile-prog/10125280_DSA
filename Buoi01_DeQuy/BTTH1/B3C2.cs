using System;

namespace BTTH1
{
    static class B3C2
    {
        //Gt 1: duyet 2..n-1 => O(n)
        static bool CoBan(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0) return false;
            return true;
        }

        // Gt 2: chi duyet den can n => O(sqrt n)
        static bool CaiTien(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            if (n % 2 == 0) return false;
            for (long i = 3; i * i <= n; i += 2)
                if (n % i == 0) return false;
            return true;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap so nguyen duong n", 97);
            Console.WriteLine($"Co ban O(n): {(CoBan(n) ? "la so nguyen to" : "khong phai so nguyen to")}");
            Console.WriteLine($"Cai tien O(sqrt n): {(CaiTien(n) ? "la so nguyen to" : "khong phai so nguyen to")}");
        }
    }
}
