using System;

namespace BTTH1
{
    static class B2C2
    {
        static int Lap(int[] a, int x)
        {
            int l = 0, r = a.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (a[mid] == x) return mid;
                if (x < a[mid]) r = mid - 1;
                else l = mid + 1;
            }
            return -1;
        }

        static int DeQuy(int[] a, int x, int l, int r)
        {
            if (l > r) return -1;
            int mid = l + (r - l) / 2;
            if (a[mid] == x) return mid;
            if (x < a[mid]) return DeQuy(a, x, l, mid - 1);
            return DeQuy(a, x, mid + 1, r);
        }

        public static void Run()
        {
            int[] a = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            Console.Write("Mang (da sap xep): ");
            hamhotro.InMang(a);
            int x = hamhotro.DocSo("Nhap so can tim", 23);
            Console.WriteLine($"Cach lap: vi tri {Lap(a, x)}");
            Console.WriteLine($"Cach de quy: vi tri {DeQuy(a, x, 0, a.Length - 1)}");
        }
    }
}
